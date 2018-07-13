using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllCleAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AllCleAPI.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
    public class TodoController : Controller
    {
        [HttpGet]
        public List<TodoItem> Get()
        {
            using (TodoContext db = new TodoContext())
            {
                return db.TodoItems.ToList();
            }
         }
        [HttpGet]
        public TodoItem Get(int Id)
        {
            using (TodoContext db = new TodoContext())
            {
                return db.TodoItems.Find(Id);
            }
        }
        [HttpGet]
        public IActionResult Post([FromBody]TodoItem obj)
        {
            using (TodoContext db = new TodoContext())
            {
                db.TodoItems.Add(obj);
                db.SaveChanges();
                return new ObjectResult("TodoItem added succesfully!");
            }
        }
        [HttpGet]
        public IActionResult Put(int id,[FromBody]TodoItem obj)
        {
            using (TodoContext db = new TodoContext())
            {
                db.Entry<TodoItem>(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
                return new ObjectResult("TodoItem modified succesfully!");
            }
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            using (TodoContext db = new TodoContext())
            {
                db.TodoItems.Remove(db.TodoItems.Find(Id));
                db.SaveChanges();
                return new ObjectResult("TodoItem deleted succesfully!");
            }
        }



        

    }
}