using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace FormQuanLySinhVien
{
    class GioiTinh
    {
        const bool Nam = true;
        const bool Nu = false;
        public bool Id { get; set; }
        public string Name { get; set; }

        public static List<GioiTinh> Get()
        {
            List<GioiTinh> lgt = new List<GioiTinh>();
            GioiTinh gtNam = new GioiTinh();
            gtNam.Id = Nam;
            gtNam.Name = "Nam ";
            lgt.Add(gtNam);

            GioiTinh gtNu = new GioiTinh();
            gtNu.Id = Nu;
            gtNu.Name = "Nu ";
            lgt.Add(gtNu);
            return lgt;

        }
    }      
 }

