using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereço { get; set; }
        public int Telefone { get; set; }
        public DateTime Data_de_Nascimento { get; set; }
    }

    public class Diretor
    {
        public string Nome { get; set; }
        public string Filme { get; set; }
    }

    public class Filme
    {
        public string titulo { get; set; }
        public int Duração { get; set; }
        public int Ano  { get; set;}
        public string produção { get; set; }
        public int Classificação { get; set; } 
        public string Gênero { get; set; }
     }
    public class Funcionario
    {
        public string Nome { get; set; }
        public string ID { get; set; }
        public string matricula { get; set; }
    }
    public class Classificação
     {
        public string Ação { get; set; }
        public string Aventura { get; set; }
        public string Comdeia { get; set; }
        public string Documentario { get; set; }
        public string Drama { get; set; }
        public string ficção_cientifica { get; set; }
        public string Musical { get; set; }
        public string Romance { get; set; }
        public string Seriado { get; set; }
        public string Suspense { get; set; }
        public string Terror { get; set; }
    }
    public class Produtora
    {
        public string Nome { get; set; }
        public int Filme { get; set; }
    }
    }




