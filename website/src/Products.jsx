import { useEffect, useState } from "react";

const ProductsTest = () => {
  const [data, setData] = useState([]);
  useEffect(() => {
    fetch("https://fakestoreapi.com/products")
      .then((res) => res.json())
      .then(data => setData(data));
  });
  return (
    <div className="products-content">
      <div className="container">
        <div className="products-header">
          <h2 className="section-head">lastest products</h2>
        </div>
        <div className="products">
          {data.map((item) => (
            <div className="product" key={item.id}>
              <img src={item.image} alt="Product"  loading="lazy"/>
              <p title={item.title}>{item.title}</p>
              <div className="product-details">
                <span className="weight">1 kg</span>
                {/* <span>{item.rating.rate}</span> */}
                <span className="price">{item.price}$</span>
              </div>
              <div className="add-product">
                <span>+</span>
              </div>
            </div>
            // <li key={item.id}>{item.title}</li>
          ))}
        </div>
      </div>
    </div>
  );
};

export default ProductsTest;
