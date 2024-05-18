import { Link } from "react-router-dom";
import CartItem from "./compoents/CartItem";

const Cart = () => {
  return (
    <div className="cart">
      <div className="container">
        <aside className="one">
          <div className="aside-header d-flex">
            <div className="left">
              <h2 className="section-head">shopping cart</h2>
            </div>
          </div>
          <div className="aside-body">
            {/* <img
          src={cartImg}
          alt=""
        /> */}
            {/* {cartItems.length === 0 && <p>your cart is empty</p> } */}
            <CartItem />
            <CartItem />
            <CartItem />
            <CartItem />
            <CartItem />
            <CartItem />
            <div className="btn">
              <Link to='/'>return to shop</Link>
            </div>
          </div>
          <div className="cart-products">{/* empty */}</div>
          <div className="aside-bottom">
            <div className="aside-check">
              <div className="chk-top d-flex">
                <span>total</span>
                <span>le 0.00</span>
              </div>
              <div className="cart-btns">
                <div className="btn">check out</div>
              </div>
            </div>
            <div className="aside-footer">
              <p>Spend LE 1,500.00 to Free Shipping</p>
            </div>
          </div>
        </aside>
      </div>
    </div>
  );
};

export default Cart;
