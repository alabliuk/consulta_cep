CREATE PROCEDURE GetAllListCeps
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
		Cep 
	FROM 
		ConsultaCep
	WHERE
		(Cep <> '' OR Cep is not null)
		AND 
			((DATEDIFF(MONTH, LastUpdate, GETDATE()) > 6)
				OR
			LastUpdate IS NULL)
END
GO