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
        /// <summary>
        /// lấy tất cả liên lạc
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// lấy tất cả liên lạc
        /// </summary>
        /// <returns></returns>
        public static List<ChiTietNhomLienLacViewModel> getListByNhomBySearch(string value, int IDNhom)
        {
            var db = new AppDBContext();
            var rs = db.ChiTietNhomLienLacs.Where(e => e.IDNhom == IDNhom && e.TenGoi.Contains(value)).Select(e => new ChiTietNhomLienLacViewModel
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
        /// <summary>
        /// lấy liên lạc theo nhóm liên lạc
        /// </summary>
        /// <param name="IDNhom"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Thêm 1 liên lạc vào trong nhóm
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>
        public static KetQua AddChiTietNhomLienLac(ChiTietNhomLienLac ct)
        {
            var db = new AppDBContext();
            var count = db.ChiTietNhomLienLacs.Where(e => e.SDT == ct.SDT).Count();
            //trường hợp số điện thoại tồn tại thì không thêm
            if(count > 0)
            {
                return KetQua.TrungMa;
            }
            else
            {
                db.ChiTietNhomLienLacs.Add(ct);
                db.SaveChanges();
                return KetQua.ThanhCong;
            }
              
        }
        /// <summary>
        /// Xóa liên lạc trong nhóm liên lạc
        /// </summary>
        /// <param name="ctn"></param>
        /// <returns></returns>
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
