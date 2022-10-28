using AppQuanLyDanhBa.Model;
using AppQuanLyDanhBa.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyDanhBa.Service
{
    class ChiTietNhomLienLacService
    {
        public enum KetQua
        {
            TrungMa = 0,
            ThanhCong = 1,
        }
        public static List<ChiTietNhomLienLacViewModel> getList()
        {
            var db = new AppDBContext();
            var rs = db.ChiTietNhomLienLacs.Select(e => new ChiTietNhomLienLacViewModel
            {
                ID = e.ID,
                TenGoi = e.TenGoi,
                Email = e.Email,
                IDNhom = e.IDNhom,
                DiaChi = e.DiaChi,
                SDT = e.SDT,
            }).ToList();
            return rs;

        }
        public static List<ChiTietNhomLienLacViewModel> getList(int IDNhom)
        {
            var db = new AppDBContext();
            var rs = db.ChiTietNhomLienLacs.Where(e => e.IDNhom == IDNhom).Select(e => new ChiTietNhomLienLacViewModel
            {
                ID = e.ID,
                TenGoi = e.TenGoi,
                Email = e.Email,
                IDNhom = e.IDNhom,
                DiaChi = e.DiaChi,
                SDT = e.SDT,
            }).ToList();
            return rs;

        }
        public static KetQua AddChiTietNhomLienLac(ChiTietNhomLienLac ct)
        {
            var db = new AppDBContext();
            
                db.ChiTietNhomLienLacs.Add(ct);
                db.SaveChanges();
                return KetQua.ThanhCong;
        }
        public static KetQua DeleteChiTietNhomLienLac(ChiTietNhomLienLacViewModel ctn)
        {
            var db = new AppDBContext();
            var lienlac = db.ChiTietNhomLienLacs.Where(e => e.ID == ctn.ID).FirstOrDefault();
            db.ChiTietNhomLienLacs.Remove(lienlac);
            db.SaveChanges();
            return KetQua.ThanhCong;
        }

    }
}
