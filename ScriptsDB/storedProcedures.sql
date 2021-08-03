--create procedure insert_customer
--@customer_name nvarchar(80),
--@customer_address nvarchar(80),
--@customer_status bit
--as
----if Exists(Select * from CLIENTES where nombre = @nombre and direccion = @direccion)
----Raiserror('Usuario ya registrado',16,1)
----else
--insert into CUSTOMERS
--values(@customer_name,@customer_address,@customer_status)

--create procedure insert_order
--@order_date datetime,
--@order_description nvarchar(100),
--@order_amount smallmoney,
--@customer_name nvarchar(80),
--@customer_address nvarchar(100)
--as
--insert into ORDERS 
--values(@order_date,@order_description,@order_amount,@customer_name,@customer_address);

--create procedure insert_unpaid_order
--@remainder smallmoney,
--@order_id int
--as
--insert into UNPAID_ORDERS 
--values(@remainder,@order_id)


--create procedure search_regular_or_irregular_customer
--@searcher nvarchar(80)
--as
--select distinct CUSTOMERS.customer_name, CUSTOMERS.customer_address, CUSTOMERS.customer_status, TELEPHONES.number from CUSTOMERS
--left join ORDERS on CUSTOMERS.customer_name = ORDERS.customer_name and CUSTOMERS.customer_address = ORDERS.customer_address
--left join TELEPHONES on (CUSTOMERS.customer_name = TELEPHONES.customer_name and CUSTOMERS.customer_address = TELEPHONES.customer_address)
--where (CUSTOMERS.customer_name like '%' + @searcher + '%' or TELEPHONES.number like '%' + @searcher + '%') and (ORDERS.order_amount>0 or ORDERS.order_amount != null) and CUSTOMERS.customer_name != 'VENTA GENERAL' and CUSTOMERS.customer_address != 'VENTA GENERAL'

--create procedure search_in_all_customers
--@searcher nvarchar(80)
--as
--select distinct CUSTOMERS.customer_name, CUSTOMERS.customer_address, CUSTOMERS.customer_status, TELEPHONES.number from CUSTOMERS
--left join TELEPHONES on (CUSTOMERS.customer_name = TELEPHONES.customer_name and CUSTOMERS.customer_address = TELEPHONES.customer_address)
--where (CUSTOMERS.customer_name like '%' + @searcher + '%' or TELEPHONES.number like '%' + @searcher + '%') and  CUSTOMERS.customer_name != 'VENTA GENERAL' and CUSTOMERS.customer_address != 'VENTA GENERAL'


--PEDIDOS HECHOS
--create procedure select_orders
--as 
--select ORDERS.order_id, ORDERS.order_date, ORDERS.order_description,
--	CUSTOMERS.customer_name, CUSTOMERS.customer_address, CUSTOMERS.customer_status
--from ORDERS
--inner join CUSTOMERS on (ORDERS.customer_name=CUSTOMERS.customer_name and ORDERS.customer_address=CUSTOMERS.customer_address)
--where ORDERS.order_amount = 0
--order by ORDERS.order_date


--ELIMINAR PEDIDO
--create procedure delete_order
--@order_id int
--as
--delete from ORDERS
--where ORDERS.order_id = @order_id 

--ACTUALIZAR PEDIDO
--create procedure update_order
--@order_id int,
--@order_date datetime,
--@order_description nvarchar(100),
--@order_amount smallmoney,
--@customer_name nvarchar(80),
--@customer_address nvarchar(100)
--as
--update ORDERS set order_date=@order_date, order_description=@order_description, order_amount=@order_amount,
--customer_name = @customer_name, customer_address=@customer_address
--where order_id = @order_id 


--create procedure select_customers
--as 
--select * 
--from CUSTOMERS

--CLIENTES CON ADEUDO
--create procedure select_irregular_customers
--as 
--select * 
--from CUSTOMERS 
--where customer_status = 1 and customer_name != 'venta general' and customer_address != 'venta general'

--CLIENTES REGULARES
--create procedure select_regular_customers
--as 
--select distinct CUSTOMERS.customer_name, CUSTOMERS.customer_address, CUSTOMERS.customer_status from CUSTOMERS
--left join ORDERS on CUSTOMERS.customer_name = ORDERS.customer_name and CUSTOMERS.customer_address = ORDERS.customer_address
--where customer_status = 0  and (ORDERS.order_amount>0 or ORDERS.order_amount != null)
--and CUSTOMERS.customer_name != 'VENTA GENERAL' and CUSTOMERS.customer_address != 'VENTA GENERAL'


--CUENTAS DE CLIENTES CON ADEUDO
--create procedure select_unpaid_orders
--as 
--select *
--from ORDERS
--inner join UNPAID_ORDERS on (ORDERS.order_id = UNPAID_ORDERS.order_id)


--INSERTAR CANTIDADES ACUMULADAS
--create procedure insert_accumulated_amount
--@amount smallmoney,
--@date_accumulated_amount datetime,
--@order_id int
--as
--insert into ACCUMULATED_AMOUNTS values(@amount, @date_accumulated_amount,  @order_id)

--ACTUALIZAR PEDIDO SIN PAGAR
----create procedure update_unpaid_order
----@order_id int,
----@remainder smallmoney
----as
----update UNPAID_ORDERS set remainder=@remainder
----where order_id = @order_id


--SELECCIONAR CANTIDADES ACUMULADAS
--create procedure select_accumulated_amounts
--@order_id int
--as
--select * 
--from ACCUMULATED_AMOUNTS
--where order_id = @order_id


--ELIMINAR PEDIDO SIN PAGAR
--create procedure delete_unpaid_order
--@order_id int
--as
--delete from UNPAID_ORDERS
--where UNPAID_ORDERS.order_id = @order_id 

--PEDIDOS PAGADOS
--create procedure select_orders_paid
--as
--select ORDERS.order_id, ORDERS.order_date, ORDERS.order_description, ORDERS.order_amount,
--	CUSTOMERS.customer_name, CUSTOMERS.customer_address, CUSTOMERS.customer_status
--from ORDERS
--left join UNPAID_ORDERS on ORDERS.order_id=UNPAID_ORDERS.order_id
--inner join CUSTOMERS on (ORDERS.customer_name = CUSTOMERS.customer_name and ORDERS.customer_address = CUSTOMERS.customer_address)
--where UNPAID_ORDERS.remainder is null and UNPAID_ORDERS.order_id is null and ORDERS.order_amount !=0 

--create procedure search_customer_order
--@searcher nvarchar(80)
--as
--select ORDERS.order_id, ORDERS.order_date, ORDERS.order_description,
--	CUSTOMERS.customer_name, CUSTOMERS.customer_address, CUSTOMERS.customer_status
--from ORDERS
--inner join CUSTOMERS on (ORDERS.customer_name=CUSTOMERS.customer_name and ORDERS.customer_address=CUSTOMERS.customer_address)
--where ORDERS.order_amount = 0
--and CUSTOMERS.customer_name+ORDERS.order_description like '%' + @searcher + '%'
