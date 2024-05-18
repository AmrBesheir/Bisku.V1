import { useState } from "react";
// import logo from "../assets/bisku logo.png";
import { Link, NavLink } from "react-router-dom";
import cartImg from "../assets/wired-flat-146-basket-trolley-shopping-card.gif";
import CartItem from "./CartItem";
import { useTranslation } from "react-i18next";
import ShoppingCart from "../ShoppingCart";

const NavBar = () => {
  const [profile, setProfile] = useState(false);
  const [showCart, setShowCart] = useState(false);
  const [showWishList, setShowWishList] = useState(false);
  const [cartItems, setCartItems] = useState([]);
  const { t } = useTranslation();

  return (
    <header>
      <div className="container">
        <div className="logo ">
          <Link to="/">
            <h2>Bisku</h2>
          </Link>

          {/* <img src={logo} alt="" width="60px" /> */}
        </div>
        <div className="main-links">
          <ul>
            <li>
              <NavLink to="/">
                <span>{t("homePageTitle")}</span>
              </NavLink>
            </li>
            <li>
              <NavLink to="/AllShops">
                <span>{t("ourshopstitle")}</span>
              </NavLink>
            </li>
            <li>
              <NavLink to="/Categories">
                <span>{t("Categories")}</span>
              </NavLink>
            </li>
          </ul>
        </div>
        <div className="right-header">
          <Link to="/Notification">
            <i className="fa-regular fa-bell"></i>
          </Link>
          <Link to="/ShoppingCart">
            <i className="fa-solid fa-cart-shopping"></i>
          </Link>
          <i
            className="fa-regular fa-user"
            onClick={() => {
              setProfile(!profile);
            }}
          >
            <div className={`user-profile ${profile ? "active" : ""}`}>
              <span>
                <i className="fa-solid fa-xmark"></i>
              </span>
              <div className="profile-details">
                <div className="singin-icon">
                  <Link to="/SingIn">
                    <i className="fa-solid fa-user"></i>
                    <button>sign in</button>
                  </Link>
                </div>
                <div className="singup-icon">
                  <Link to="/SingUp">
                    <i className="fa-solid fa-user-plus"></i>
                    <button>signup</button>
                  </Link>
                </div>
              </div>
            </div>
          </i>
          <Link to="/Wishlist">
            <i className="fa-solid fa-heart"></i>
          </Link>
        </div>
        <div className="mobile-menu">
          <ul>
            <li>
              <Link to="/">
                <i className="fa-solid fa-house"></i>
                <span>{t("homePageTitle")}</span>
              </Link>
            </li>
            <li>
              <Link to="/AllShops">
                <i className="fa-solid fa-shop"></i>
                <span>{t("ourshopstitle")}</span>
              </Link>
            </li>
            <li>
              <Link to="/Categories">
                <i className="fa-solid fa-list"></i>
                <span>{t("Categories")}</span>
              </Link>
            </li>
          </ul>
        </div>
      </div>
    </header>
  );
};

export default NavBar;
