create database SalesControl
use SalesControl

create table CUSTOMERS(
customer_name nvarchar(80),
customer_address nvarchar(100),
customer_status bit,
constraint pk_customers primary key (customer_name,customer_address)
)

create table TELEPHONES(
customer_name nvarchar(80) not null,
customer_address nvarchar(100) not null,
number nvarchar(15),
constraint u_telephones unique(customer_name,customer_address,number),
constraint u_number unique(number),
constraint fk_telephones foreign key (customer_name,customer_address) references CUSTOMERS(customer_name, customer_address)
on delete cascade
on update cascade
)

create table ORDERS(
order_id int identity(1,1),
order_date datetime not null,
order_description nvarchar(100) not null,
order_amount smallmoney,
customer_name nvarchar(80)  not null,
customer_address nvarchar(100)  not null,
constraint pk_orders primary key (order_id),
constraint fk_orders foreign key (customer_name,customer_address) references CUSTOMERS(customer_name, customer_address)
on delete cascade
on update cascade
)

create table UNPAID_ORDERS(
remainder smallmoney not null,
order_id int,
constraint pk_unpaid_orders primary key (order_id),
constraint fk_unpaid_orders foreign key (order_id) references ORDERS(order_id)
on delete cascade
on update cascade
)

create table ACCUMULATED_AMOUNTS(
amount smallmoney not null,
date_accumulated_amount datetime not null,
order_id int,
constraint fk_accumulated_amounts foreign key (order_id) references UNPAID_ORDERS(order_id)
on delete cascade
)