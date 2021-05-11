using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MensajeroModel.DTO;

namespace MensajeroModel.DAL
{
    public class MensajesDALArchivos : IMensajesDAL{
        
        private MensajesDALArchivos()
        {

        }
        private static IMensajesDAL instancia;
        public static IMensajesDAL GetInstance()
        {
            if(instancia == null)instancia = new MensajesDALArchivos();
                return instancia;
        }
        public List<Mensaje> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save(Mensaje m)
        {
            throw new NotImplementedException();
        }
    }
}
