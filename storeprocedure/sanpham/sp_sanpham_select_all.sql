-- ================================================
-- Create Procedure sp_sanpham_select_all.SQL
-- Sản phẩm select all
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Sok Kim Thanh>
-- Create date: <07/11/2023>
-- Description:	<Sản phẩm select all>
-- =============================================
drop procedure if exists sp_sanpham_select_all
go
CREATE PROCEDURE sp_sanpham_select_all
	-- Add the parameters for the stored procedure here
	@ma nvarchar(11) = N'',
	@ten nvarchar(256) = N'',
	@gia money = 0,
	@soluong int = 0,
	@nhacungcap nvarchar(11) = null,
	@danhmuc nvarchar(11) = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from sanpham
END
GO
