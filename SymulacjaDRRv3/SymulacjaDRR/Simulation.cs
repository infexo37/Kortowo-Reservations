using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SymulacjaDRR
{
    internal static class Simulation
    {
        internal volatile static int AlgorithmSpeed = 3;
        internal volatile static bool AlgorithmDelay = true;
        internal volatile static bool AlgorithmStepped = false;
        internal volatile static bool AlgorithmNextStepAvailable = false;
        internal static Button AlgorithmStepButton = null;

        private static void ToggleButton()
        {
            if (AlgorithmStepButton.InvokeRequired)
            {
                AlgorithmStepButton.Invoke(new MethodInvoker(() => AlgorithmStepButton.Enabled = true));
            }
        }

        internal async static Task RunDRRSimulation(CancellationToken token, List<PacketQueue> queues)
        {
            bool running = true;
            PacketQueue currentQueue = null;
            QueueContainer currentQC = null;

            while (running)
            {
                if (token.IsCancellationRequested || !running)
                    break;

                for (int i = 0; i < queues.Count; i++)
                {
                    currentQueue = queues[i];
                    currentQC = currentQueue.QueueContainer;

                    currentQC.ChangeColorActive();

                    if(AlgorithmStepped)
                    {
                        AlgorithmNextStepAvailable = false;
                        ToggleButton();
                        while (!AlgorithmNextStepAvailable && AlgorithmStepped)
                        {
                            await Task.Delay(100);
                        }
                    }
                    else if (AlgorithmDelay)
                        await Task.Delay(300 / AlgorithmSpeed);

                    if (currentQueue.Count > 0)
                    {
                        currentQueue.IncreaseDeficit();
                        
                        if (AlgorithmDelay)
                            await Task.Delay(400 / AlgorithmSpeed);

                        Packet packet = null;

                        while (currentQueue.Count > 0 && (packet = currentQueue.Peek()) != null)
                        {
                            BlockControl block = packet.Block;

                            block.ChangeColorProcessing();

                            if (AlgorithmStepped)
                            {
                                AlgorithmNextStepAvailable = false;
                                ToggleButton();
                                while (!AlgorithmNextStepAvailable && AlgorithmStepped)
                                {
                                    await Task.Delay(100);
                                }
                            }
                            else if (AlgorithmDelay)
                                await Task.Delay(600 / AlgorithmSpeed);

                            if (packet.Length > currentQueue.CurrentDeficit)
                            {
                                block.ChangeColorRejected();

                                if (AlgorithmStepped)
                                {
                                    AlgorithmNextStepAvailable = false;
                                    ToggleButton();
                                    while (!AlgorithmNextStepAvailable && AlgorithmStepped)
                                    {
                                        await Task.Delay(100);
                                    }
                                }
                                else if (AlgorithmDelay)
                                    await Task.Delay(400 / AlgorithmSpeed);

                                block.ChangeColorInitial();

                                break;
                            }

                            block.ChangeColorAccepted();

                            if (AlgorithmStepped)
                            {
                                AlgorithmNextStepAvailable = false;
                                ToggleButton();
                                while (!AlgorithmNextStepAvailable && AlgorithmStepped)
                                {
                                    await Task.Delay(100);
                                }
                            }
                            else if (AlgorithmDelay)
                                await Task.Delay(400 / AlgorithmSpeed);

                            block.Destroy();

                            currentQueue.Dequeue();

                            packet.Block = null;
                            packet = null;

                            if (token.IsCancellationRequested)
                            {
                                running = false;
                                break;
                            }
                        }
                    }

                    if (currentQueue.Count == 0)
                    {
                        currentQueue.ResetDeficit();
                    }

                    currentQC.ChangeColorInitial();

                    if (token.IsCancellationRequested || !running)
                    {
                        running = false;
                        break;
                    }

                    if (AlgorithmStepped)
                    {
                        AlgorithmNextStepAvailable = false;
                        ToggleButton();
                        while (!AlgorithmNextStepAvailable && AlgorithmStepped)
                        {
                            await Task.Delay(100);
                        }                        
                    }
                    else if (AlgorithmDelay)
                        await Task.Delay(300 / AlgorithmSpeed);
                }
            }
        }
    }
}
