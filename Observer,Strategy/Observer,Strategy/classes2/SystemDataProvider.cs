using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Strategy.classes2
{
    internal class SystemDataProvider : SimpleSystemDataProvider

    {
        private float previousCPULoad;
        private float previousRAMAvailable;
        // Prag od 10% izražen kao faktor (0.10)
        private const float ChangeThreshold = 0.10f;

        public SystemDataProvider() : base()
        {
            this.previousCPULoad = this.CPULoad;
            this.previousRAMAvailable = this.AvailableRAM;
        }

        public float GetCPULoad()
        {
            float currentLoad = this.CPULoad;

            // Računanje postotne razlike u odnosu na prethodno stanje
            float difference = 0;
            if (this.previousCPULoad != 0)
            {
                difference = Math.Abs(currentLoad - this.previousCPULoad) / this.previousCPULoad;
            }
            else if (currentLoad > 0)
            {
                difference = 1.0f; // Ako je prošli bio 0, a sada je veći, to je promjena od 100%
            }

            // Obavijesti promatrače samo ako je razlika veća ili jednaka 10% (0.10)
            if (difference >= ChangeThreshold)
            {
                this.Notify();
                this.previousCPULoad = currentLoad; // Ažuriramo bazu za iduću usporedbu samo kad se okine Notify
            }

            return currentLoad;
        }

        public float GetAvailableRAM()
        {
            float currentRAM = this.AvailableRAM;

            // Računanje postotne razlike u odnosu na prethodno stanje
            float difference = 0;
            if (this.previousRAMAvailable != 0)
            {
                difference = Math.Abs(currentRAM - this.previousRAMAvailable) / this.previousRAMAvailable;
            }
            else if (currentRAM > 0)
            {
                difference = 1.0f;
            }

            // Obavijesti promatrače samo ako je razlika veća ili jednaka 10% (0.10)
            if (difference >= ChangeThreshold)
            {
                this.Notify();
                this.previousRAMAvailable = currentRAM; // Ažuriramo bazu za iduću usporedbu samo kad se okine Notify
            }

            return currentRAM;
        }

    }
}
