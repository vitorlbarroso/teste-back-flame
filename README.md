Desafio back-end FlamePay.

- Tecnologias que precisam ser utilizadas no teste:
  1. C#
  2. .NET 6
  3. Entity Framework
  - Banco de Dados MySql

- Proposta do desafio:
Se imagine comprando em um site e você está na tela de checkout. Para realizar a compra, você precisa ter um produto selecionado, selecionar o método de pagamento, preencher as informações necessárias, realizar o pagamento e o seu pagamento será salvo em uma base de dados.
O time da empresa buscará pelas compras que foram realizadas, irão verificar os dados de envio do produto, e assim que enviarem, irão marcar o produto como enviado.

- Roteiro:
  1. Deve existir no banco uma tabela chamada "Products" com as seguintes colunas:
     1. Id
     2. Name
     3. Description - Nullable
     4. Price
     5. IsBlocked - Default False
     6. Timestamps
     
  2. Deve existir também uma tabela chamada "Sales" com as seguintes colunas:
     1. Id
     2. ProductId - Relacionamento com tabela Products
     3. PaymentMethod - Enum (PIX, Cartão de Crédito, Boleto)
     4. PaymentStatus - Enum (Paid, WaitPayment, Chargeback, Refund)
     5. PurchaseCode - Unique
     6. DeliveryAddressState
     7. DeliveryAddressCity
     8. DeliveryAddressComplement
     9. DeliveryAddressZipCode
     10. AmountPaid - Consultar na hora da venda na tabela Products
     11. Status - Enum (WaitingToBeSent, Sent, Received, Returned)

- Rotas que devem existir:
  1. Rotas de produtos:
     1. Criar novo produto
     2. Editar um produto
     3. Bloquear um produto
     4. Pegar os produtos existentes por status (Blockeds, NotBlocked, AllProducts)

  2. Rotas de vendas:
     1. Criar nova venda
     2. Buscar todas as vendas por status (WaitingToBeSent, Sent, Received, Returned)
     3. Atualizar o status de uma venda
     4. Atualizar o status do pagamento de uma venda

- Fluxo do sistema:
  Usuário realiza a compra, o back verifica o preço do produto passado na requisição, cadastra a venda como "Paid" e "WaitingToBeSent" e gera um código único para aquela venda (FP*número aleatório*).
