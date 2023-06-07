using System;
using System.Collections.Generic;
using System.Drawing;
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

namespace WpfApp1
{
	/// <summary>
	/// Логика взаимодействия для Auto.xaml
	/// </summary>
	public partial class Auto : Page
	{
        static public string userName = "";
        static public string userLogin = "";
        static public string userPartonymic = "";
        static public string userFamilia = "";
        static public int userID = 0;

        static string symbols = "1234567890qwertyuioplkjhgfdsazxcvbnmQWERTYUIOPALSKDJFHGMNZBVXC";
		static Random r = new Random();
		public Auto()
		{

			InitializeComponent();
			var index = r.Next(symbols.Length);
			var index2 = r.Next(symbols.Length);
			var index3 = r.Next(symbols.Length);
			var index4 = r.Next(symbols.Length);



			pictureBox1.Text = symbols[index].ToString() + symbols[index2].ToString() + symbols[index3].ToString() + symbols[index4].ToString();
			
		}

		private void btnAuto(object sender, RoutedEventArgs e)
		{
			bool valid = false;
			TradeEntities1 tradeEntities1 = new TradeEntities1();
			if(String.IsNullOrWhiteSpace(tbxLogin.Text) || string.IsNullOrWhiteSpace(tbxPassword.Text))
			{
				MessageBox.Show("Вы не заполнили все поля");
			} else
			{
				using (tradeEntities1)
				{
					var users = tradeEntities1.User;
					foreach (User us in users) {
						if (tbxLogin.Text == us.UserLogin.Trim() && tbxPassword.Text == us.UserPassword.Trim())
						{
                            userID = us.UserID;
                            valid = true;
							if (us.UserRole == 3 || us.UserRole == 2)
							{
                                var queryKlient = from d in tradeEntities1.User
                                                  where d.UserID == userID
                                                  select d;
                                foreach (User d in queryKlient)
                                {
                                    userName = d.UserName;
                                    userFamilia = d.UserSurname;
                                    userID = d.UserID;
                                    userPartonymic = d.UserPatronymic;
                                }

                                WindowLK windowPage2 = new WindowLK();
								windowPage2.Show();
								App.Current.Windows[0].Close();
							}
							else
								MessageBox.Show("Вы успешно авторизовались");
                        }
					}
				}
				if (valid == false)
				{
					MessageBox.Show("Неверный логин или пароль");
                    open.Visibility = Visibility.Hidden;
					img1.Visibility = Visibility.Hidden;
                    brd_Capcha.Visibility = Visibility.Visible;
                    tbxLogin.Text = "";
                    tbxPassword.Text = "";
                }
            }
		}

		private void btnCheck_Kapcha(object sender, RoutedEventArgs e)
		{
			if (Capcha.Text == null || Capcha.Text != pictureBox1.Text)
			{
				var index = r.Next(symbols.Length);
				var index2 = r.Next(symbols.Length);
				var index3 = r.Next(symbols.Length);
				var index4 = r.Next(symbols.Length);

				pictureBox1.Text = symbols[index].ToString() + symbols[index2].ToString() + symbols[index3].ToString() + symbols[index4].ToString();
				MessageBox.Show("Капча была введена неправильно");

			} else if (Capcha.Text == pictureBox1.Text)
			{
				brd_Capcha.Visibility = Visibility.Hidden;
				Capcha.Text = "";

                var index = r.Next(symbols.Length);
                var index2 = r.Next(symbols.Length);
                var index3 = r.Next(symbols.Length);
                var index4 = r.Next(symbols.Length);

                pictureBox1.Text = symbols[index].ToString() + symbols[index2].ToString() + symbols[index3].ToString() + symbols[index4].ToString();
				open.Visibility = Visibility.Visible;
				img1.Visibility = Visibility.Visible;
            }
			else
			{
				MessageBox.Show("Возникла ошибка");
			}
		}

		private void urlGost(object sender, RoutedEventArgs e)
		{
			userID = 0;
			userFamilia = "";
			userPartonymic = "";
			userName = "";
		}
	}
}
