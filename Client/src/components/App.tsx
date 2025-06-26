


import { useEffect, useState } from "react";
import "./App.css";
import { IProduct } from "../model/IProduct";
import Header from "./Header";
import ProductList from "./ProductList";



function App() {

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
    <>
      <Header products={products} />
      <ProductList products={products} addProduct={addProduct} />
    </>
  );
}







export default App;
