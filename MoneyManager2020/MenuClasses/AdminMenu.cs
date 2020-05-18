using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MoneyManager2020.MenuClasses
{
    public class AdminMenu
    {
        private Admin admin;
        private int id;
        private string email;
        private AdminMenuForm activeMenu;
        private Connect connect = Connect.GetInstance();
        private SqlCommand command = new SqlCommand();
        private SqlDataReader reader;

        public AdminMenu(AdminMenuForm menuForm, Admin admin)
        {
            this.admin = admin;
            this.id = admin.ID;
            this.email = admin.Email;
            this.activeMenu = menuForm;
        }

    }
}
