import AllShops from "./AllShops";
import Home from "./Home";
import Categories from "./Categories";
import "./css/style.css";
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import SignIn from "./SignIn";
import SignUp from "./SignUp";
import ShopDetails from "./ShopDetails";
import CategoryDetails from "./CategoryDetails";
import ShoppingCart from "./ShoppingCart"
import Notification from './Notification'
import Wishlist from './Wishlist'


function App() {
  return (
    <>
      <Router>
        <Routes>
          <Route path="/" element={<Home />}></Route>
          <Route path="/AllShops" element={<AllShops />}></Route>
          <Route path="/Categories" element={<Categories />}></Route>
          <Route path="/SingIn" element={<SignIn />}></Route>
          <Route path="/SingUp" element={<SignUp />}></Route>
          <Route path="/ShopDetails" element={<ShopDetails />}></Route>
          <Route path="/CategoryDetails" element={<CategoryDetails />}></Route>
          <Route path="/ShoppingCart" element={<ShoppingCart />}></Route>
          <Route path="/Notification" element={<Notification />}></Route>
          <Route path="/Wishlist" element={<Wishlist />}></Route>
        </Routes>
      </Router>
    </>
  );
}

export default App;
