CREATE PROCEDURE SaveCepProcessed
	@Cep VARCHAR(8)
	,@Logradouro VARCHAR(200)
	,@Complemento VARCHAR(200)
	,@Bairro VARCHAR(100)
	,@Localidade VARCHAR(100)
	,@Uf VARCHAR(2)
	,@Ibge INT
	,@Gia INT
	,@Ddd INT
	,@Siafi INT

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE ConsultaCep SET
		Logradouro = @Logradouro
		,Complemento = @Complemento
		,Bairro = @Bairro
		,Localidade = @Localidade
		,Uf = @Uf
		,Ibge = @Ibge
		,Gia = @Gia
		,Ddd = @Ddd
		,Siafi = @Siafi
		,LastUpdate= GETDATE()
	WHERE
		Cep = @Cep
	
	SELECT @@ROWCOUNT

END
GO

