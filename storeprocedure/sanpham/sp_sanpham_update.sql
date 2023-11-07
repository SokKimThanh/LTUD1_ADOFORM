﻿-- ================================================
-- Create Procedure sp_sanpham_update.sql
-- Sản phẩm update
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
-- Description:	<Mô tả>
-- =============================================
drop procedure if exists sp_sanpham_update
go
CREATE PROCEDURE sp_sanpham_update
	-- Add the parameters for the stored procedure here
	@ma nvarchar(11) = '', 
	@ten nvarchar(256) = N'',
	@ghichu nvarchar(256) = N''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update danhmuc set ten = @ten, ghichu = @ghichu where ma = @ma -- chuẩn sql
END
GO
