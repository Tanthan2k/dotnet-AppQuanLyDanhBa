using AppQuanLyDanhBa.Model;
using AppQuanLyDanhBa.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyDanhBa.Service
{
    class NhomLienLacService
    {
        public enum KetQua
        {
            TrungMa = 0,
            ThanhCong = 1,
        }
        public static List<NhomLienLacViewModel> getList()
        {
            var db = new AppDBContext();
            var rs = db.NhomLienLacs.Select(e => new NhomLienLacViewModel
            {
                ID = e.ID,
                TenNhom = e.TenNhom,
            }).ToList();
            return rs;

        }
        public static KetQua AddNhomLienLac(NhomLienLac nll)
        {
            var db = new AppDBContext();
            db.NhomLienLacs.Add(nll);
            db.SaveChanges();
            return KetQua.ThanhCong;
        }
        /*
        //Update Sinh Viên
        public static KetQua UpdataLopHoc(LopHocViewModel lh)
        {
            var db = new AppDBContext();
            var lopHoc = db.LopHocs.Where(e => e.ID == lh.ID).FirstOrDefault();
            lopHoc.TenLop = lh.TenLop;
            db.SaveChanges();
            return KetQua.ThanhCong;
        }
       */
        public static KetQua DeleteNhopLienLac(NhomLienLacViewModel lh)
        {
            var db = new AppDBContext();
            var nhomLienLac = db.NhomLienLacs.Where(e => e.ID == lh.ID).FirstOrDefault();
            var lienLac = db.ChiTietNhomLienLacs.Where(e => e.IDNhom == lh.ID).FirstOrDefault();
            if (lienLac == null)
            {
                db.NhomLienLacs.Remove(nhomLienLac);
                db.SaveChanges();
                return KetQua.ThanhCong;
            }
            return KetQua.TrungMa;
        }
    }
}
