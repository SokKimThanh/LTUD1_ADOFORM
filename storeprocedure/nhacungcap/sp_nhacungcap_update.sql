-- ================================================
-- Create Procedure sp_nhacungcap_update.sql
-- Nhà cung cấp update
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
drop procedure if exists sp_nhacungcap_update
go
CREATE PROCEDURE sp_nhacungcap_update
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
	update nhacungcap set ten = @ten, ghichu = @ghichu where ma = @ma -- chuẩn sql
END
GO
