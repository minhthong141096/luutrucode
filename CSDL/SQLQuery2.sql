/****** Script for SelectTopNRows command from SSMS  ******/
--10 sản phẩm có đơn giá lớn nhất
select top(10) *
from HangHoa
order by DonGia DESC
-- 10 sản phẩm có đơn giá nhỏ nhất 
select top(10)*
from HangHoa
order by DonGia ASC
-- tìm sản phẩm "chai"
select *
from HangHoa
where TenHH like '%ch%'
--tìm sản phẩm mã 1029
select *
from HangHoa
where MaHH = 1029
--tìm hàng hóa có mã loại 1000
select *
from HangHoa
where MaLoai = 1000 
-- tìm mã loại hàng hóa 1000 & 1001
select *
from HangHoa
where MaLoai =1000 or MaLoai = 1001 or MaLoai =1002
--cách 2
select *
from HangHoa
where MaLoai not in(1000,1001,1002)
--tìm giá lớn nhất
select *
from HangHoa
where DonGia =(
select top(1) DonGia
from HangHoa
order by DonGia DESC)
--tìm hàng hóa có giá từ 50 -100
select * 
from HangHoa
where DonGia >=50 and DonGia <= 100
--cách 2
select *
from HangHoa
where DonGia between 50 and 100
--đếm số loại hàng hóa
select count(*),MaLoai
from HangHoa
group by MaLoai 
--lấy mã loại 1000
select count(MaLoai) as Tong
from HangHoa
where MaLoai = 1000
--tính tổng số lần xem
select sum (SoLanXem)
from HangHoa
where TenHH  like '%kobe%'

-- gộp 2 bảng
select a.*, b.TenLoai 
from  HangHoa as a , Loai as b
where a.MaLoai = b.MaLoai 

--gộp 3 bảng
select a.*, b.TenLoai, c.TenCongTy
from  HangHoa as a , Loai as b, NhaCungCap as c
where a.MaLoai = b.MaLoai and a.MaNCC = c.MaNCC

--lấy hàng hóa của Nokia cung cấp seafood
select a.*, b.TenLoai, c.TenCongTy
from  HangHoa as a , Loai as b, NhaCungCap as c
where a.MaLoai = b.MaLoai and a.MaNCC = c.MaNCC 
and c.TenCongTy like '%nokia%' and b.TenLoai like '%seafood%'