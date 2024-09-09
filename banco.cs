namespace poo {
    public class ContaBanco {
        public int numConta;
        protected string tipo;
        private string dono;
        private float saldo;
        private bool status;

        public ContaBanco() {
            saldo = 0;
            status = false;
        }

        // Conta
        public void setNumConta(int n) {
            this.numConta = n;
        }

        public int getNumConta() {
            return this.numConta;
        }

        // Tipo
        public void setTipo(string t) {
            this.tipo = t;
        }

        public string getTipo() {
            return this.tipo;
        }

        // Dono
        public void setDono(string d) {
            this.dono = d;
        }

        public string getDono() {
            return this.dono;
        }

        // Saldo
        public void setSaldo(float s) {
            this.saldo = s;
        }

        public float getSaldo() {
            return this.saldo;
        }

        // Status
        public void setStatus(bool s) {
            this.status = s;
        }

        public bool getStatus() {
            return this.status;
        }

        // Métodos Específicos
        public void estadoAtual() {
            Console.WriteLine("Conta: " + this.getNumConta());
            Console.WriteLine("Tipo: " + this.getTipo());
            Console.WriteLine("Dono: " + this.getDono());
            Console.WriteLine("Saldo: " + this.getSaldo());
            Console.WriteLine("Status: " + this.getStatus());
            Console.WriteLine("-------------------------------");
        }

        public void abrirConta(string t) {
            setTipo(t);
            setStatus(true);

            if (t == "CC") {
                Console.WriteLine("Conta aberta com sucesso!");
                setSaldo(50);
            } else if (t == "CP") {
                Console.WriteLine("Conta aberta com sucesso!");
                setSaldo(150);
            }
        }

        public void fecharConta() {
            if (getSaldo() > 0) {
                Console.WriteLine("Sua conta não está vazia!");
            } else if(getSaldo() < 0){
                Console.WriteLine("Sua conta tem débitos pendentes!");
            } else {
                setStatus(false);
                Console.WriteLine("Sua conta foi fechada com sucesso!");
            };
        }

        public void depositar(float v) {
            if (getStatus() == true) {
                setSaldo(getSaldo() + v);
                Console.WriteLine("Você depositou: " + v + " reais.");
            } else {
                Console.WriteLine("Você precisa ter uma conta aberta para depositar!");
            }
        }

        public void sacar(float v) {
            if (getStatus() == true) {
                if(getSaldo() >= v) {
                    setSaldo(getSaldo() - v);
                    Console.WriteLine("Saque realizado! Você acaba de sacar: " + v + " reais.");
                } else {
                    Console.WriteLine("Você não tem saldo suficiente.");
                }
            } else {
                Console.WriteLine("Você precisa ter uma conta aberta para sacar!");
            }
        }

        public void pagarMensal() {
            float v;

            if(getTipo() == "CC"){
                v = 12;

                if(getStatus() == true ) {
                    if(getSaldo() >= v ) {
                        setSaldo(getSaldo() - v);
                    } else {
                        Console.WriteLine("Saldo insuficiente");
                    }
                } else {
                    Console.WriteLine("Você precisa ter uma conta aberta para pagar");
                }
            } else if(getTipo() == "CP") {
                v = 20;

                if(getStatus() == true ) {
                    if(getSaldo() >= v ) {
                        setSaldo(getSaldo() - v);
                    } else {
                        Console.WriteLine("Saldo insuficiente");
                    }
                } else {
                    Console.WriteLine("Você precisa ter uma conta aberta para pagar");
                }
            }

        }
    }
}