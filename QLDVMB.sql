use QLDVMB;
go
CREATE TABLE KhachHang (
    MaKhachHang INT IDENTITY(1,1) PRIMARY KEY,  
    Ho NVARCHAR(50) NOT NULL,                
    TenDemVaTen NVARCHAR(100) NOT NULL,       
    NgaySinh DATE NOT NULL,               
    GioiTinh NVARCHAR(10) CHECK (GioiTinh IN ('Nam', 'Nữ', 'Khác')),
    SoDienThoai VARCHAR(15) UNIQUE NOT NULL,   
    Email NVARCHAR(100) UNIQUE NOT NULL,      
    MatKhau NVARCHAR(255) NOT NULL,          
    CCCD VARCHAR(12),         
    QuocTich NVARCHAR(50),           
    DiaChi NVARCHAR(255),                     
    NgayDangKy DATETIME DEFAULT GETDATE()      
);
