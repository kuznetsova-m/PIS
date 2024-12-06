using System;
using System.Windows.Forms;
using RoadmapApp.Models;
using RoadmapApp.Repositories;

namespace RoadmapApp.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string phone = txtPhone.Text.Trim();
            string pass = txtPassword.Text.Trim();
            if (string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Введите телефон и пароль.");
                return;
            }

            var existing = Program.UserRepo.GetByPhone(phone);
            if (existing != null)
            {
                MessageBox.Show("Пользователь с таким телефоном уже зарегистрирован.");
                return;
            }

            User user = new User(phone, pass);
            Program.UserRepo.Add(user);
            MessageBox.Show("Регистрация успешно выполнена! Теперь можете войти.");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string phone = txtPhone.Text.Trim();
            string pass = txtPassword.Text.Trim();
            if (string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Введите телефон и пароль.");
                return;
            }

            var user = Program.UserRepo.GetByPhoneAndPassword(phone, pass);
            if (user == null)
            {
                MessageBox.Show("Неверный телефон или пароль.");
                return;
            }

            // Переход на главную форму
            FormMain mainForm = new FormMain(user);
            mainForm.Show();
            this.Hide();
        }
    }
}
