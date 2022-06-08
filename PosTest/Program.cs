using IGPOS.Data.Models.UserRoleModel;
using IGPOS.Data.Service.Auth;
using IGPOS.Data.Service.Setting;
Console.WriteLine("Hello, World!");
var auth = new AuthenticationService();
var user = new User {Username = "admin", Password = "123456"};
auth.Login(user);


Console.WriteLine($"cur:: {auth.GetCurrentUser().WorkShift?.Name}");
var menuService = new MenuService();


foreach (var menu in menuService.GetMenuByCurrentUser())
{
    Console.WriteLine($":: {menu.Color}");
}