-- 1

CREATE TABLE users(
  id SERIAL PRIMARY KEY,
  full_name VARCHAR(100),
  phone VARCHAR(20) UNIQUE check(phone like '+%'),
  email TEXT UNIQUE check(email like '%@%'),
  birth_day  DATE CHECK (birth_day <= CURRENT_DATE),
  created_at TIMESTAMP
);

-- 2

CREATE TABLE orders(
  order_id serial PRIMARY KEY,
  user_id int not null REFERENCES users(id),
  total_price numeric(10, 2) check (total_price >= 0),
  created_at TIMESTAMP,
  status INT
);

-- 3

CREATE TABLE order_items (
    id SERIAL PRIMARY KEY,
    order_id int not null REFERENCES orders(order_id),
    product_id INT not null REFERENCES products(id),
    quantity int not null check(quantity > 0),
    cost numeric(10, 2) check(cost >= 0)
);

-- 4

CREATE TABLE products (
    product_id SERIAL PRIMARY KEY,
    name VARCHAR(100),
    category_id int not null REFERENCES categories(id),
    cost numeric(10, 2) check(cost >= 0),
    stock VARCHAR
);

-- 5

CREATE TABLE categories(
  id serial PRIMARY KEY,
  title TEXT(100),
  parent_id FOREIGN KEY not null REFERENCES categories(id);
);

-- 6

CREATE TABLE payments (
    id SERIAL PRIMARY KEY,
    order_id FOREIGN key not null REFERENCES orders(id),
    amount numeric(10, 2) check (amount >= 0),
    pay_date TIMESTAMP,
    method VARCHAR(100)
);

-- 7

CREATE TABLE suppliers (
    id serial PRIMARY KEY,
    name VARCHAR(100),
    contact VARCHAR(100),
    phone VARCHAR(20) CHECK(phone like '+%');
);


-- 8

CREATE TABLE supply_items (
    id SERIAL PRIMARY KEY,
    supply_id FOREIGN key REFERENCES suppliers(id),
    product_id FOREIGN KEY REFERENCES products(product_id),
    count INT;
);

-- 9
CREATE TABLE logs (
    id serial PRIMARY KEY,
    user VARCHAR(100),
    action VARCHAR(100) not null,
    created_at TIMESTAMP not null DEFAULT current_timestamp
);

-- 10
CREATE TABLE reviews (
    id serial PRIMARY KEY,
    user FOREIGN KEY REFERENCES users(id),
    product FOREIGN KEY REFERENCES products(product_id),
    text VARCHAR(100),
    stars int(5) Check (stars >= 0);
);

