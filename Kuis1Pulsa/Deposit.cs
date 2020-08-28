using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuis1Pulsa {
    public class Deposit {
        private int saldo;
        public Deposit(int a) {
            saldo = a;
        }
        public Deposit() {
            
        }
        public int Saldo {
            get { return saldo; }
            set { saldo = value; }
        }

        public int SaldoKurang(int a) {
            return Saldo -= a;
        }
    }
}
