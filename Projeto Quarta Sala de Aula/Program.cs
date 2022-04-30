using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Quarta_Sala_de_Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Disciplinas objDisciplina = new Disciplinas();
            objDisciplina.NomeProfessor = "";
            objDisciplina.Sala = "";


            Materias objMaterias = new Materias();
            objMaterias.IDMateria = "";
            objMaterias.TipoMateria = "";

            Questoes objQuestoes = new Questoes();
            objQuestoes.Quantidade = "";
            objQuestoes.Bimestre = "";
            objQuestoes.Tipo = "";
            objQuestoes.IdQuestoes = "";


            Teste objTeste = new Teste();
            objTeste.Gabarito = "";
            objTeste.Data = "";
            objTeste.Nome = "";
            objTeste.Resultado = "";

            Console.WriteLine("** Bem-Vindo ao Cadastro de Professores **");


            //IDentificação do Professor

            Console.WriteLine("Informe o seu Nome de Professor(a)");
            objDisciplina.NomeProfessor = Console.ReadLine();
            Console.WriteLine("\r\n");
            Console.WriteLine("**Bem-Vindo Professor " + objDisciplina.NomeProfessor + "\r\n");


            //Identificação da Sala

            Console.WriteLine("** Professor " + objDisciplina.NomeProfessor + " Informe a Sala a Qual ira Adminsitrar Suas Aulas **");
            Console.WriteLine("** Professor Suas Opções de Sala São: " + "1, 2 e 3 **");
            string IdSala = Console.ReadLine();

            while (IdSala != "1" && IdSala != "2" && IdSala != "3")
            {
                Console.WriteLine("** Professor " + objDisciplina.NomeProfessor + " Informe a Sala a Qual Ira Administrar Suas Aula **");
                Console.WriteLine("** Professor Suas Opções de Sala São: " + "1, 2 e 3 **");
                IdSala = Console.ReadLine();
            }

            objDisciplina.Sala = IdSala;

            if (objDisciplina.Sala == "1")
            {

                objDisciplina.Sala = "Sala 1";
                Console.WriteLine("** Foi Escolhida a " + objDisciplina.Sala + " ** \r\n");

            }
            else if (objDisciplina.Sala == "2")
            {
                objDisciplina.Sala = "Sala 2";
                Console.WriteLine("** Foi Escolhida a " + objDisciplina.Sala + " ** \r\n");

            }
            else if (objDisciplina.Sala == "3")
            {
                objDisciplina.Sala = "Sala 3";
                Console.WriteLine("** Foi Escolhida a " + objDisciplina.Sala + " ** \r\n");

            }


            //Identificação Materias

            Console.WriteLine("** Qual Máteria Será Aplicada **");
            Console.WriteLine("** Digite 1 Para Português ou 2 Para Matematica ** \r\n");
            string VarMateria = Console.ReadLine();

            while (VarMateria != "1" && VarMateria != "2")
            {
                Console.WriteLine("** Materia Não Encontrada **");
                Console.WriteLine("** Digite 1 Para Português ou 2 Para Matematica **");
                VarMateria = Console.ReadLine();
            }

            objMaterias.IDMateria = VarMateria;

            if (objMaterias.IDMateria == "1")
            {
                objMaterias.IDMateria = "1";
                Console.WriteLine("** A Materia Selecionada foi Portugues ** \r\n");

            }
            else if (objMaterias.IDMateria == "2")
            {
                objMaterias.IDMateria = "2";
                Console.WriteLine("** A Materia Selecionada foi Matematica ** \r\n");
            }

            Console.WriteLine("** O questionario deverá conter: \r\n");


            //Identificação do Bimestre

            Console.WriteLine("** O Bimestre **");
            Console.WriteLine("** Digite de qual Bimestre será o Questionrio **");
            string IdBimestre = Console.ReadLine();

            while (IdBimestre != "1" && IdBimestre != "2" && IdBimestre != "3" && IdBimestre != "4")
            {
                Console.WriteLine("** Bimestre Não Encontrado **");
                Console.WriteLine("** Digite de qual Bimestre será o Questionario **");
                IdBimestre = Console.ReadLine();
            }

            objQuestoes.Bimestre = IdBimestre;
            Console.WriteLine("** Foi escolhido o " + IdBimestre + " Bimestre **\r\n");


            /*Console.WriteLine("** Tipo de Questões");
            Console.WriteLine("** Digite 1 para Multipla Escolha ou 2 para Dissertativa **");
            string IdTipo = Console.ReadLine();


            //Identificação do Tipo das Ques~toes

            while (IdTipo != "1" && IdTipo != "2")
            {
                Console.WriteLine("** Foi Digitado Incorretamente **");
                Console.WriteLine("** Digite 1 para Multipla Escolha ou 2 para Dissertativa **");
                IdTipo = Console.ReadLine();
            }

            objQuestoes.Tipo = IdTipo;

            if (objQuestoes.Tipo == "1")
            {
                objQuestoes.Tipo = "Questões de Multipla Escolha";
                Console.WriteLine("** Foi Escolhido as " + objQuestoes.Tipo + " **\r\n");
            }
            else if (objQuestoes.Tipo == "2")
            {
                objQuestoes.Tipo = "Questões Dissertativas";
                Console.WriteLine("** Foi Escolhido as " + objQuestoes.Tipo + " **\r\n");
            }
            */

            //Identificação da Quantidade de Questões

            Console.WriteLine("** Quantidade de Questões");
            Console.WriteLine("** O Questionario deverá ter no Máximo 20 Questões **");
            Console.WriteLine("** Em nosso Banco de Dados ja Temos Alguns ja prontos para Serem Utilizados **");
            Console.WriteLine("** 1° Questionario = 5 Questões Digite 1 **");
            Console.WriteLine("** 1° Questionario = 10 Questões Digite 2 **");
            Console.WriteLine("** 1° Questionario = 15 Questões Digite 3 **");
            Console.WriteLine("** 1° Questionario = 20 Questões Digite 4 **");
            string IdQuantidade = Console.ReadLine();

            while (IdQuantidade != "1" && IdQuantidade != "2" && IdQuantidade != "3" && IdQuantidade != "4")
            {
                Console.WriteLine("** Digitou Errado o Numero do Questionario, Porfavor Digite Novamente **");
                Console.WriteLine("** 1° Questionario = 5 Questões Digite 1 **");
                Console.WriteLine("** 2° Questionario = 10 Questões Digite 2 **");
                Console.WriteLine("** 3° Questionario = 15 Questões Digite 3 **");
                Console.WriteLine("** 4° Questionario = 20 Questões Digite 4 **");
                IdQuantidade = Console.ReadLine();
            }

            objQuestoes.Quantidade = IdQuantidade;
            Console.WriteLine("** Voce Escolheu o " + objQuestoes.Quantidade + " Questionario ** \r\n");

            if (objQuestoes.Quantidade == "1")
            {
                string PrimieroQuestionario = "";
            }
            else if (objQuestoes.Quantidade == "2")
            {
                string SegundoQuestionario = "";
            }
            else if (objQuestoes.Quantidade == "3")
            {
                string TerceiroQuestionario = "";
            }
            else if (objQuestoes.Quantidade == "4")
            {
                string QuartoQuestionario = "";
            }

            Console.Clear();

            //Identificação Aluno

            Console.WriteLine("Aluno Informe seu Nome:");
            objTeste.Nome = Console.ReadLine();

            Console.WriteLine("** Bem-Vindo Aluno " + objTeste.Nome + " 0**");
            Console.WriteLine("** Aqui Voce Poderá Fazer o seu Questionario que o seu Professor " + objDisciplina.NomeProfessor + "Preparou para Você \r\n **");
            Console.WriteLine("** Quando o Questionario estiver Pronto o Professor Irá Informa-lo**");

        }
    }
}