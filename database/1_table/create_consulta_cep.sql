CREATE TABLE [dbo].[ConsultaCep](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Cep] [varchar](8) NOT NULL,
	[Logradouro] [varchar](200) NULL,
	[Complemento] [varchar](200) NULL,
	[Bairro] [varchar](100) NULL,
	[Localidade] [varchar](100) NULL,
	[Uf] [varchar](2) NULL,
	[Ibge] [int] NULL,
	[Gia] [int] NULL,
	[Ddd] [int] NULL,
	[Siafi] [int] NULL,
	[LastUpdate] [datetime] NULL,
 CONSTRAINT [PK_ConsultaCep] PRIMARY KEY CLUSTERED 
(
	[Id] DESC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

