using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.IO;
using System.Web;
using ProductManagement.Models;

namespace ProductManagement.Controllers
{
    public class ProductCrudController : ApiController
    {
        ProductDBEntities pd = new ProductDBEntities();

        public IHttpActionResult getProduct()
        {
            var results = pd.tblProducts.ToList();
            return Ok(results);
        }
        [HttpPost]
        public IHttpActionResult prdinsert(tblProduct prdinsert)
        {
           // pd.tblProducts.Add(prdinsert);
            //pd.SaveChanges();
            return Ok();
        }

        public IHttpActionResult GetPrdid(int id)
        {
            ProductClass prddetails = null;
            prddetails = pd.tblProducts.Where(x => x.Id == id).Select(x => new ProductClass()
            {
                Id = x.Id,
                Name = x.Name,
                Category = x.Category,
                Price = x.Price,
                Quantity = x.Quantity,
                ShortDescription = x.ShortDescription,
                LongDescription = x.LongDescription,
                SmallImage = x.SmallImage,
                LargeImage = x.LargeImage,
            }).FirstOrDefault<ProductClass>();
            if (prddetails == null)
            {
                return NotFound();
            }
            return Ok(prddetails);
        }
        public IHttpActionResult Put(ProductClass pc)
        {
            var updateprd = pd.tblProducts.Where(x => x.Id == pc.Id).FirstOrDefault<tblProduct>();
            if (updateprd != null)
            {
                updateprd.Id = pc.Id;
                updateprd.Name = pc.Name;
                updateprd.Category = pc.Category;
                updateprd.Price = pc.Price;
                updateprd.Quantity = pc.Quantity;
                updateprd.ShortDescription = pc.ShortDescription;
                updateprd.LongDescription = pc.LongDescription;
                updateprd.SmallImage = pc.SmallImage;
                updateprd.LargeImage = pc.LargeImage;

                pd.SaveChanges();
            }
            else
            {
                return NotFound();
            }
            return Ok();
        }
        public IHttpActionResult Delete(int id)
        {
            var prddel = pd.tblProducts.Where(x => x.Id == id).FirstOrDefault();
            pd.Entry(prddel).State = System.Data.Entity.EntityState.Deleted;
            pd.SaveChanges();

            return Ok();
        }
        public IHttpActionResult getprdname(string search)
        {
            var result = pd.tblProducts.Where(x => x.Name.StartsWith(search) || search == null).ToList();
            return Ok(result);
        }

       
    }
}
