using MySqlComMigration.Migrations;
using MySqlComMigration.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MySqlComMigration {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Contexto, Configuration>()); 

            using (var ctx = new Contexto()) {

                ctx.Pessoa.ToList();
                //Student stud = new Student() { StudentName = "New Student é são maça" };

                //ctx.Students.Add(stud);

                //decimal nota = 9;

                //Contato cont = new Contato() { nome = "Contato 1", dNota = nota };

                //ctx.Contato.Add(cont);

                //Pessoa pess = new Pessoa() { nome = "Pessoa" };

                //ctx.Pessoa.Add(pess);

                ////Contato conts = ctx.Contato.Find(1);

                ////Console.WriteLine(conts.nome);

                ////conts.nome = conts.nome + " alterado 5";
                ////conts.dNota = 5;


                //ctx.SaveChanges();
            }


        }
    }
}
