using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication11.Pages;

namespace WebApplication11
{
    public class LoginModel : PageModel
    {
        public List<User> users;
        [BindProperty]
        public string Login { get; set; }

        [BindProperty]
        public string Pass { get; set; }
        public void OnGet()
        {
            @ViewData["LoginMessage"] = "There you can log in";
        }
        public void OnPost()
        {
                users = new List<User>();
                users.Add(new Pages.User("a", "a"));
                bool check = false;
                foreach (User x in users)
                {
                if (ViewData["User"] !=null) 
                    {
                        @ViewData["LoginMessage"] = "You`re logged already";

                    }
                    else if (this.Login == x.Login && this.Pass == x.Pass)
                    {
                        ViewData["User"] = "Hello " + x.Login + "!";
                    
                        check = true;
                    Redirect("./Index");
                        break;
                    }
                }

                if (!check)
                {
                    ViewData["Error"] = "No such user";
                }
            }
            
        }
    }
