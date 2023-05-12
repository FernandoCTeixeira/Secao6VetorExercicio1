namespace Exercicio1 {
    internal class Estudante {
        public string Nome { get; set; }
        public string Email { get; set; }



        public Estudante() { 
        }

        public Estudante(string nome, string email) {
            this.Nome = nome;
            this.Email = email;
        }


        public override string ToString() {
            return Nome
                + ", "
                + Email;
        }
    }
}
