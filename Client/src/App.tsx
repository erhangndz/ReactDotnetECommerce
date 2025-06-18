/* eslint-disable @typescript-eslint/no-unused-vars */

/* eslint-disable @typescript-eslint/no-explicit-any */

import { useEffect, useState } from "react";
import "./App.css";
import { IProduct } from "./model/IProduct";

const products = [
  { id: 1, name: "Product 1", price: 100, isActive: true },
  { id: 2, name: "Product 2", price: 200, isActive: true },
  { id: 3, name: "Product 3", price: 300, isActive: true },
  

];

function App() {
  return (
    <>
      <Header />
      <ProductList />
    </>
  );
}

function Header() {
  return (
    <header>
      <h1>Header</h1>
    </header>
  );
}

function ProductList() {
const [products, setProducts] = useState<IProduct[]>([
 
  

]);

useEffect(()=>{
  fetch("https://localhost:5001/api/products")
  .then(response=> response.json())
  .then(data=> setProducts(data));
}, []);


function addProduct() {
  setProducts([...products, { id: products.length + 1, name: `Product ${products.length + 1}` ,stock: products.length+1, price: (products.length + 1) * 100, isActive: true }]);
}


  return (
    <div>
      <h2>Product List</h2>

      {products.map((p) => (
        <Product key={p.id} product={p} />
      ))}

      <button onClick={addProduct}>Add Product</button>
    </div>
  );
}

function Product(props: any) {
  return (
    <>
      {props.product.isActive ? (
        <div>
          <h3>{props.product.name} </h3>
          <p>{props.product.price} ₺</p>
        </div>
      ) : <p>Ürün Satışta değil</p>  }
    </>
  );
}

export default App;
