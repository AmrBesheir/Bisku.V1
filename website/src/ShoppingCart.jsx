import Cart from "./Cart"
import NavBar from "./compoents/NavBar"
import Footer from './compoents/Footer'

const ShoppingCart = () => {
  return (
    <div className="shopping-cart">
        <NavBar />
        <Cart />
        <Footer />
    </div>
  )
}

export default ShoppingCart