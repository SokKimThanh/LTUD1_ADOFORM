-- ================================================
-- Create Procedure sp_nhacungcap_delete.sql
-- Nhà cung cấp delete
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
DROP PROCEDURE IF EXISTS sp_nhacungcap_delete
GO
CREATE PROCEDURE sp_nhacungcap_delete
	-- Add the parameters for the stored procedure here
	@ma nvarchar(11) = '', 
	@ten nvarchar(256) = N'',
	@ghichu nvarchar(256) = N''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Delete statements for procedure here
	DELETE FROM nhacungcap WHERE ma = @ma
END
GO
