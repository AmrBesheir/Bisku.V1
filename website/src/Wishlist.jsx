import CartItem from "./compoents/CartItem";
import Footer from "./compoents/Footer";
import NavBar from "./compoents/NavBar";

const Wishlist = () => {
  return (
    <div className="wishlist-wrap">
      <NavBar />
      <div className="container">
        <h2 className="section-head">
            my wishlist
        </h2>
        <CartItem />
        <CartItem />
        <CartItem />
      </div>
      <Footer />
    </div>
  );
};

export default Wishlist;
