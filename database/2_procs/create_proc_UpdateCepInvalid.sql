CREATE PROCEDURE UpdateCepInvalid
	@cep VARCHAR(8)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE 
		ConsultaCep 
			SET LastUpdate =  GETDATE()
	WHERE Cep = @cep

	SELECT @@ROWCOUNT
END
GO