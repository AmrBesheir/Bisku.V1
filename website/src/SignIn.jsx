import { useState } from "react";
import NavBar from "./compoents/NavBar";
import { Link, useNavigate } from "react-router-dom";
import { ToastContainer, toast } from "react-toastify";
import "react-toastify/dist/ReactToastify.css";
import Footer from "./compoents/Footer";

const SignIn = () => {
  const [Email, setEmail] = useState("");
  const [Password, setPassword] = useState("");

  const naviggate = useNavigate();

  const handleSubmit = (e) => {
    e.preventDefault();
    if (validation()) {
      //   GO TO HOME PAGE
      //   wait the api
      // fetch("")
      fetch(`http://localhost:8000/users/${Email}`)
        .then((res) => res.json())  
        .then((data) => {
          if (Object.keys(data).length === 0) {
            toast.error("Please Enter Valid Email");
          } else {
            if (data.Password === Password) {
              naviggate("/");
            } else {
              toast.error("Please Enter Valid Password");
            }
          }
        })
        .catch((error) => {
          console.error("Error fetching data:", error);
          toast.error("An error occurred while fetching data");
        });
    }
  };

  const validation = () => {
    let result = true;
    if (Email === "" || Email === null) {
      result = false;
      toast.warning("Please Enter Email");
    }
    if (Password === "" || Password === null) {
      result = false;
      toast.warning("Please Enter password");
    }
    return result;
  };

  return (
    <>
      <NavBar />
      <div className="Sing-form">
        <div className="container">
          <h1 className="logo gradient-text">Bisku</h1>
          <h2 className="head">Sign in to your Bisku Account</h2>
          <form action="" onSubmit={handleSubmit}>
            <div className="text-input">
              <label>email</label>
              <input
                type="email"
                placeholder="enter your email"
                value={Email}
                onChange={(e) => setEmail(e.target.value)}
              />
            </div>
            <div className="text-input">
              <label>password</label>
              <input
                type="password"
                placeholder="enter your password"
                value={Password}
                onChange={(e) => setPassword(e.target.value)}
              />
            </div>
            <button type="submit">sing in</button>
          </form>
          <p>don't have an account ?</p>
          <button className="signup-btn">
            <Link to="/SingUp">sing up</Link>
          </button>
          <ToastContainer />
        </div>
      </div>
      <Footer />
    </>
  );
};

export default SignIn;
