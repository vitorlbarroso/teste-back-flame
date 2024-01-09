Desafio back-end FlamePay.

- Tecnologias que precisam ser utilizadas no teste:
  - C#
  - .NET 6
  - Entity Framework
  - Banco de Dados MySql

- O que esperamos do teste:
  - Praticidade ao trabalhar com as tecnologias propostas.
  - Utilização de boas práticas de desenvolvimento.

- Proposta do desafio:
Se imagine comprando em um site e você está na tela de checkout. Para realizar a compra, você precisa ter um produto selecionado, selecionar o método de pagamento, preencher as informações necessárias, realizar o pagamento e o seu pagamento será salvo em uma base de dados.
O time da empresa buscará pelas compras que foram realizadas, irão verificar os dados de envio do produto, e assim que enviarem, irão marcar o produto como enviado.

- Roteiro:
  1. Deve existir no banco uma tabela chamada "Products" com as seguintes colunas:
     - Id
     - Name
     - Description - Nullable
     - Price
     - IsBlocked - Default False
     - Timestamps
     
  2. Deve existir também uma tabela chamada "Sales" com as seguintes colunas:
     - Id
     - ProductId - Relacionamento com tabela Products
     - PaymentMethod - Enum (PIX, Cartão de Crédito, Boleto)
     - PaymentStatus - Enum (Paid, WaitPayment, Chargeback, Refund)
     - PurchaseCode - Unique
     - BuyerFullName
     - BuyerDocument
     - DeliveryAddressState
     - DeliveryAddressCity
     - DeliveryAddressComplement
     - DeliveryAddressZipCode
     - AmountPaid - Consultar na hora da venda na tabela Products
     - Status - Enum (WaitingToBeSent, Sent, Received, Returned)

- Rotas que devem existir:
  1. Rotas de produtos:
     - Criar novo produto
     - Editar um produto
     - Bloquear um produto
     - Pegar os produtos existentes por status (Blockeds, NotBlocked, AllProducts)

  2. Rotas de vendas:
     - Criar nova venda
     - Buscar todas as vendas por status (WaitingToBeSent, Sent, Received, Returned)
     - Atualizar o status de uma venda
     - Atualizar o status do pagamento de uma venda

- Fluxo do sistema:
  Usuário realiza a compra, o back verifica o preço do produto passado na requisição, cadastra a venda como "Paid" e "WaitingToBeSent" e gera um código único para aquela venda (FP*número aleatório*).
