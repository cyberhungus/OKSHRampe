using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiScreenPlayer
{
    internal class SettingsContainer
    {
        public int runtimeA = 10;
        public int runtimeB = 10;
        public int runtimeMotor = 10;

        public SettingsContainer(int runtimeA, int runtimeB, int runtimeMotor) {
            this.runtimeA = runtimeA;
            this.runtimeB = runtimeB;
            this.runtimeMotor = runtimeMotor;
        }
    }
}
