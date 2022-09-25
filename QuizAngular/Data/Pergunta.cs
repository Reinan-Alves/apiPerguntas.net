using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAngular.Data
{
    public class Pergunta
    {

        public int id { get; set; }

        public string texto { get; set; }

        public string resposta { get; set; }

        public bool liberada { get; set; }

    }
}
