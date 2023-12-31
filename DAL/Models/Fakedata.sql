﻿use  QLKS_Du_An_1
go

insert into ChucVu
values ('c2809517-bc4f-4abd-b541-f1203cefe14d','CV1',N'Giám Đốc'),
		('ff13e79d-e06d-4f19-aab4-1b20f8f0a3b0','CV2',N'Nhân Viên Quèn'),
		('470af744-a3c1-4fda-b4d8-8ac078d20632','CV3',N'Quản Lý Quèn'),
		('c5802e5f-0a50-4921-a7ef-90c92c2ad306','CV4',N'Bảo Vệ')
insert into NhanVien
values ('49ae747b-5ba8-4c8f-a4ad-7fa4e915809c','NV1',N'Nguyễn A','2/2/2000',1,N'Gầm Cầu','0987654321','031234567890',1000,'c2809517-bc4f-4abd-b541-f1203cefe14d'),
		('9d8a046c-782a-4aa5-ae00-43cc5385a5ba','NV2',N'Nguyễn B','2/2/2000',1,N'Gầm Cầu','0987654321','031234567891',1000,'ff13e79d-e06d-4f19-aab4-1b20f8f0a3b0'),
		('75b2fb2d-d5f7-4055-bb44-deabd9a35111','NV3',N'Nguyễn C','2/2/2000',0,N'Gầm Cầu','0987654321','031234567892',1000,'470af744-a3c1-4fda-b4d8-8ac078d20632'),
		('99cf6035-da08-46d4-b094-bd1da5a9171d','NV4',N'Nguyễn D','2/2/2000',1,N'Gầm Cầu','0987654321','031234567893',1000,'c5802e5f-0a50-4921-a7ef-90c92c2ad306'),
		('163d1b9f-0254-4d80-a634-9002dcdbe102','NV5',N'Nguyễn E','2/2/2000',1,N'Gầm Cầu','0987654321','031234567890',1000,'c5802e5f-0a50-4921-a7ef-90c92c2ad306')
insert into TaiKhoan
values ('a0def50d-3efb-40f6-a54a-d6511b019638','NV1','123',0,'49ae747b-5ba8-4c8f-a4ad-7fa4e915809c'),
		('c240241b-b6dd-4605-bab3-ba62866ea170','NV2','123',1,'9d8a046c-782a-4aa5-ae00-43cc5385a5ba'),
		('0fa5fee8-bc9f-4940-a961-c1b554bae7dd','NV3','123',1,'75b2fb2d-d5f7-4055-bb44-deabd9a35111'),
		('4f29cb6b-1c96-456b-8cfd-ad9119d52e67','NV4','123',1,'99cf6035-da08-46d4-b094-bd1da5a9171d'),
		('6124996c-49da-4cf0-a990-164ae55494a7','NV5','123',1,'163d1b9f-0254-4d80-a634-9002dcdbe102')
insert into KhachHang
values('e1f3f710-491c-4100-825e-e47f41176bed','KH1',N'Trần A',039876543210,0912356789,N'Cầu Papper',1,N'Việt Nam'),
		('55262fb8-08b1-4beb-b09b-fd7f4c5fdabd','KH2',N'Trần B',039876543211,0912356789,N'Cầu Papper',0,N'Việt Nam'),
		('0cf393ce-c4b6-46cd-9ae7-e2c13082cee7','KH3',N'Trần C',039876543212,0912356789,N'Cầu Papper',0,N'Việt Nam'),
		('da1c1cbc-4767-4c4b-94e3-c6f583fb2f7a','KH4',N'Trần D',039876543213,0912356789,N'Cầu Papper',1,N'Việt Nam')
insert into LoaiDichVu
values('85c87692-4fda-4cbe-8449-f2080bf4fb84','DV1',N'Dịch Vụ 1'),
		('d00ca269-6c8a-4748-b4af-515e374a8bec','DV2',N'Dịch Vụ 2'),
		('fd692cb8-d807-4732-943b-2fae8f36f98e','DV3',N'Dịch Vụ 3'),
		('f69bc3a2-fc80-49da-b72d-d792da7b1970','DV4',N'Dịch Vụ 4')
insert into LoaiPhong
values('36d195a5-f31a-42ed-bde7-1c959dd4317e','LP1',N'Loại Phòng 1',10,100),
		('9094c31d-e013-4d60-9efa-312228767ea4','LP2',N'Loại Phòng 2',10,200),
		('e3f90502-8719-4205-938a-5229f04723c4','LP3',N'Loại Phòng 3',10,300),
		('40852914-9e25-4362-96d0-8cbaa36c192a','LP4',N'Loại Phòng 4',10,400)
insert into LoaiTienNghi
values('9768a004-5ea2-4421-99ac-6cf7c1d1406c','LTN1',N'Loại Tiện Nghi 1'),
		('98b34d42-049e-4665-baba-9ab75d92b67e','LTN2',N'Loại Tiện Nghi 2'),
		('04ee0e39-5f16-4195-bd3c-7ed68e94ecc2','LTN3',N'Loại Tiện Nghi 3'),
		('e0d47f05-00b3-43f3-a805-b47117e35a22','LTN4',N'Loại Tiện Nghi 4')
insert into PhieuThue
values('8716e1e8-9ffe-4ba5-a097-6f9a643e8d7a',2/2/2000,'e1f3f710-491c-4100-825e-e47f41176bed','9d8a046c-782a-4aa5-ae00-43cc5385a5ba'),
		('6e909cd4-14e7-4984-8a63-4afc8c090b9ea',2/2/2000,'55262fb8-08b1-4beb-b09b-fd7f4c5fdabd','9d8a046c-782a-4aa5-ae00-43cc5385a5ba'),
		('8244895b-ccff-4ccc-84f9-2af9d16576c6',2/2/2000,'0cf393ce-c4b6-46cd-9ae7-e2c13082cee7','75b2fb2d-d5f7-4055-bb44-deabd9a35111'),
		('3425f1aa-158b-403a-bb00-88e6eaf02de7',2/2/2000,'da1c1cbc-4767-4c4b-94e3-c6f583fb2f7a','9d8a046c-782a-4aa5-ae00-43cc5385a5ba')
insert into DichVu
values('36209f47-b65c-49e6-bc35-338a1e21c265','DV1',N'Dịch vụ 1',100,'85c87692-4fda-4cbe-8449-f2080bf4fb84'),
		('41d510da-de25-4961-b018-7999e7b1bb94','DV2',N'Dịch vụ 2',200,'d00ca269-6c8a-4748-b4af-515e374a8bec'),
		('2c077ae4-7388-4b24-ae01-7b74e2a5c8b3','DV3',N'Dịch vụ 3',300,'fd692cb8-d807-4732-943b-2fae8f36f98e'),
		('83f65b15-2bec-41a4-a4fc-44eb3d0a82d0','DV4',N'Dịch vụ 4',400,'f69bc3a2-fc80-49da-b72d-d792da7b1970')
insert into Phong
values('427D71FB-0AB7-4B00-A841-12DA5571B35F','P101',0,'36D195A5-F31A-42ED-BDE7-1C959DD4317E'),
		('5724BC55-95A9-4D0B-BC4F-A114FB7025B2','P103',0,'40852914-9E25-4362-96D0-8CBAA36C192A'),
		('EC71DFFE-6375-4EFE-B991-A8392B59DF06','P301',1,'E3F90502-8719-4205-938A-5229F04723C4'),
		('EC71DFFE-6375-4EFE-B991-A8392B59DF06','P102',0,'40852914-9E25-4362-96D0-8CBAA36C192A'),
		('EC71DFFE-6375-4EFE-B991-A8392B59DF06','P201',1,'9094C31D-E013-4D60-9EFA-312228767EA4')
insert into ChiTietTienNghi
values('49E596DA-2A85-400A-BF15-2470D4FB95A6','CTTN4',N'Chi Tiết Tiện Nghi 4','E0D47F05-00B3-43F3-A805-B47117E35A22','D8BF5029-E61C-4470-B13F-F3F3C804274F'),
		('484F85F9-5556-4060-82B0-3B9A5D063DF7','CTTN3',N'Chi Tiết Tiện Nghi 3','04EE0E39-5F16-4195-BD3C-7ED68E94ECC2','EC71DFFE-6375-4EFE-B991-A8392B59DF06'),
		('00F2632C-C7D6-407A-8AA3-6EC2A7947D96','CTTN2','Chi Tiết Tiện Nghi 2','98B34D42-049E-4665-BABA-9AB75D92B67E','5AD9C846-3D2D-41CA-839F-FF9590CC8063'),
		('36ACCAD5-B7F6-49FE-A40B-B6EFA535C101','CTTN5','Chi Tiết Tiện Nghi 6','E0D47F05-00B3-43F3-A805-B47117E35A22','5724BC55-95A9-4D0B-BC4F-A114FB7025B2'),
		('D897F66D-0140-4D51-8E7A-CDA7344620CF','CTTN1','Chi Tiết Tiện Nghi 1','9768A004-5EA2-4421-99AC-6CF7C1D1406C','427D71FB-0AB7-4B00-A841-12DA5571B35F')
insert into CTPhieuThue
values('596C31E3-1817-411C-AC8E-05B6DAE688D8','2000/1/1','2000/1/12','8716E1E8-9FFE-4BA5-A097-6F9A643E8D7A','427D71FB-0AB7-4B00-A841-12DA5571B35F'),
		('6D891106-843A-4BAD-B15B-0C9F7A1066F1','2000/01/01','2000/01/02','8716E1E8-9FFE-4BA5-A097-6F9A643E8D7A','5724BC55-95A9-4D0B-BC4F-A114FB7025B2'),
		('48cb0388-6618-42bf-8185-e3d02ad5decd','2000/01/01','2000/01/02','6e909cd4-14e7-4984-8a63-4afc8c090b9ea','EC71DFFE-6375-4EFE-B991-A8392B59DF06'),
		('c684ce5d-c15c-42c5-b767-5f802fdeed13','2000/01/01','2000/01/02','8244895b-ccff-4ccc-84f9-2af9d16576c6','D8BF5029-E61C-4470-B13F-F3F3C804274F'),
		('32e8c3a0-b9fc-482d-b3a9-a6b5ee87909a','2000/01/01','2000/01/02','3425f1aa-158b-403a-bb00-88e6eaf02de7','5AD9C846-3D2D-41CA-839F-FF9590CC8063')
insert into HoaDon
values('3387b226-51fe-4268-858b-ccf2cfb1208d','HD1','2/2/2000','596C31E3-1817-411C-AC8E-05B6DAE688D8'),
		('5ccf528d-d87d-44bb-aa6b-27ce5e6d3b08','HD2','2/2/2000','6D891106-843A-4BAD-B15B-0C9F7A1066F1'),
		('34426141-0a78-4ed1-8498-815842d6841d','HD3','2/2/2000','48cb0388-6618-42bf-8185-e3d02ad5decd'),
		('1bedc88d-f0dd-497e-b6f4-27469cac66ef','HD4','2/2/2000','c684ce5d-c15c-42c5-b767-5f802fdeed13'),
		('66ab56c5-7172-4e51-be9e-c2f5f72a2078','HD5','2/2/2000','32e8c3a0-b9fc-482d-b3a9-a6b5ee87909a')
insert into HoaDonChiTiet
values('36209F47-B65C-49E6-BC35-338A1E21C265','1BEDC88D-F0DD-497E-B6F4-27469CAC66EF',6,100),
		('36209F47-B65C-49E6-BC35-338A1E21C265','5CCF528D-D87D-44BB-AA6B-27CE5E6D3B08',6,100),
		('83F65B15-2BEC-41A4-A4FC-44EB3D0A82D0','34426141-0A78-4ED1-8498-815842D6841D',6,400),
		('41D510DA-DE25-4961-B018-7999E7B1BB94','66AB56C5-7172-4E51-BE9E-C2F5F72A2078',6,200),
		('2C077AE4-7388-4B24-AE01-7B74E2A5C8B3','3387B226-51FE-4268-858B-CCF2CFB1208D',6,300)
