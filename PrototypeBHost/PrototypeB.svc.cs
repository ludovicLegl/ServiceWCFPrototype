using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PrototypeBHost
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PrototypeB" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PrototypeB.svc or PrototypeB.svc.cs at the Solution Explorer and start debugging.
    public class PrototypeB : IprototypeB
    {
        private HandyMobileDatabase model = new HandyMobileDatabase();
        public void AddTest(Test  patient)
        {
            try
            {
               // Test test = JsonConvert.DeserializeObject<Test>(patient);
                 model.Test.Add(patient);
                 model.SaveChangesAsync();
            }
            catch (Exception e)
            {
                string test = e.Message;
            }
        }

        public void DeleteTest(Test test)
        {
            // throw new NotImplementedException();
            try
            {
                Test sql = (from t in model.Test
                          where t.Id_test == test.Id_test
                          select t).Single();
                model.Test.Remove(sql);
                model.SaveChangesAsync();
            }
            catch(Exception ex)
            {
               string etito= ex.Message;
            }
          
        }


        public List<Test> GetPatientList()
        {

            List<Test> listpatients = (from pat in model.Test select pat).ToList();

            return (List<Test>)listpatients;
        }

        public Test GetTestId(string id)
        {
            // string patient = null;
            /*
            var patient = (from pat in model.Patient
                        where pat.id_patient.ToString().Equals(id)
                        select pat).Single();
             return new Patient() {id_patient=patient.id_patient ,pat_nom = patient.pat_nom */
            Test pat = (from t in model.Test where t.Id_test.ToString().Equals(id) select t).Single();

            return new Test() { Id_test = pat.Id_test, tes_test = pat.tes_test };
    
           //return new Patient1() { Id = id, Name = "Test" };
        }


        public void UpdateTest(Test test)
        {
            Test result = (from p in model.Test
                           where p.Id_test == test.Id_test
                           select p).SingleOrDefault();

            result.tes_test = test.tes_test;

            model.SaveChangesAsync();
        }
        public string JsonData(string id)
        {
            return "You requested product" + id;
        }
        public string XmlData(string id)
        {
            return "You requested product" + id;
        }
    }
    public class Patient1
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

}