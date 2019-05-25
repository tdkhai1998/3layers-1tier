CREATE SCHEMA `quanlisach` ;

CREATE TABLE `quanlisach`.`sach` (
  `masach` INT NOT NULL AUTO_INCREMENT,
  `tensach` NVARCHAR(100) NULL,
  `namxuatban` INT NULL,
  `tacgia` NVARCHAR(45) NULL,
  `tomtat` NVARCHAR(500) NULL,
  `theloai` NVARCHAR(45) NULL,
  `soluong` INT NULL,
  PRIMARY KEY (`masach`));
INSERT INTO `quanlisach`.`sach` (`tensach`, `namxuatban`, `tacgia`, `tomtat`, `theloai`, `soluong`) VALUES ('Kỹ thuật lập trình', '2014', 'Trần Đan Thư', 'Đây là giáo trình nối tiếp theo sau quyển \"Nhập môn lập trình\".', 'Giáo trình', '2');