using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataSetWebApi.Models;

namespace DataSetWebApi.Controllers
{
    public class PersonController : ApiController
    {
        DataSetWebApi.Models.DataSet1TableAdapters.PersonTableAdapter personTableAdapter = new Models.DataSet1TableAdapters.PersonTableAdapter();

        // GET: api/Person
        public DataSet1.PersonDataTable Get()
        {
            return personTableAdapter.GetData();
        }

        // GET: api/Person/5
        public DataSet1.PersonDataTable Get(int id)
        {
            return personTableAdapter.GetDataById(id); ;
        }

        // POST: api/Person
        public void Post([FromBody]Person newPerson)
        {
            personTableAdapter.InsertQuery(newPerson.Id, newPerson.Name, newPerson.Age);
        }

        // PUT: api/Person/5
        public void Put(int id, [FromBody]Person updatePerson)
        {
            personTableAdapter.UpdateQuery(updatePerson.Name, updatePerson.Age, id);
        }

        // DELETE: api/Person/5
        public void Delete(int id)
        {
            personTableAdapter.DeleteQuery(id);
        }
    }
}
