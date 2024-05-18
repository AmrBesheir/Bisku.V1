import NavBar from "./compoents/NavBar";
import { Link, useNavigate } from "react-router-dom";
import Footer from "./compoents/Footer";
import { ToastContainer, toast } from "react-toastify";

import { useState } from "react";

const SignUp = (required) => {
  const handlesubmit = (e) => {
    e.preventDefault();
    let regObj = {
      fname,
      lname,
      email,
      phone,
      password,
      city,
      country,
      street,
      zCode,
    };
    console.log(regObj);
    const requestOptions = {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify(regObj),
    };
    fetch("http://localhost:8000/users", requestOptions)
      .then((res) => {
        toast.success("Welcome ! You are registered successfully");
        // naviggate('/SingIn')
      })
      .catch((err) => {
        toast.error("failed :" + err.message);
      });
  };
  const handleBlur = () => {
    if (fname.trim().length < 3) {
      toast.info("First Name Should Be At Least Three Characters Long!");
    }
  };
  const pwdBlur = () => {
    if (password.trim().length < 8) {
      toast.info("Password Should Be At Least Eight Characters Long!");
    }
  };

  const [fname, setFname] = useState("");
  const [lname, setLname] = useState("");
  const [email, setEmail] = useState("");
  const [phone, setPhone] = useState("");
  const [password, setPassword] = useState("");
  const [city, setCity] = useState("");
  const [country, setCountry] = useState("");
  const [street, setStreet] = useState("");
  const [zCode, setZcode] = useState("");
  // const [password, setPassword] = useState("");
  const naviggate = useNavigate();

  return (
    <>
      <NavBar />
      <div className="Sing-form">
        <div className="container">
          <h2 className="head ">
            Sign up to your <span className="grad">Bisku</span> Account
          </h2>
          <form action="" onSubmit={handlesubmit}>
            <div className="name">
              <div className="text-input">
                <label>
                  <span style={{ color: "red", fontSize: "16px" }}>* </span>
                  first name
                </label>
                <input
                  type="text"
                  value={fname}
                  placeholder="enter your first name"
                  onChange={(e) => setFname(e.target.value)}
                  onBlur={handleBlur}
                  pattern=".{3,}"
                  title="First Name Should Be At Least Three Characters Long!"
                  required={required}
                />
              </div>
              <div className="text-input">
                <label>last name</label>
                <input
                  type="text"
                  value={lname}
                  placeholder="enter your last name"
                  onChange={(e) => setLname(e.target.value)}
                  onBlur={handleBlur}
                />
              </div>
            </div>
            <div className="text-input">
              <label>
                <span style={{ color: "red", fontSize: "16px" }}>* </span>
                email
              </label>
              <input
                type="email"
                value={email}
                placeholder="enter your email"
                onChange={(e) => setEmail(e.target.value)}
                required
              />
            </div>
            <div className="text-input">
              <label>
                <span style={{ color: "red", fontSize: "16px" }}>* </span>{" "}
                password
              </label>
              <input
                type="password"
                value={password}
                placeholder="enter your password"
                onChange={(e) => setPassword(e.target.value)}
                pattern=".{8,}"
                title="Eight or more characters"
                onBlur={pwdBlur}
                required
              />
            </div>
            <div className="text-input">
              <label>
                <span style={{ color: "red", fontSize: "16px" }}>* </span> phone
                number
              </label>
              <input
                type="text"
                value={phone}
                placeholder="enter your phone number"
                onChange={(e) => setPhone(e.target.value)}
                required
              />
            </div>
            <div className="text-input">
              <label>city</label>
              <input
                type="text"
                value={city}
                placeholder="enter your city"
                onChange={(e) => setCity(e.target.value)}
              />
            </div>
            <div className="text-input">
              <label>country</label>
              <input
                type="text"
                value={country}
                placeholder="enter your country"
                onChange={(e) => setCountry(e.target.value)}
              />
            </div>
            <div className="text-input">
              <label>street</label>
              <input
                type="text"
                value={street}
                placeholder="enter your street"
                onChange={(e) => setStreet(e.target.value)}
              />
            </div>
            <div className="text-input">
              <label>zip code</label>
              <input
                type="text"
                value={zCode}
                placeholder="enter your zip code"
                onChange={(e) => setZcode(e.target.value)}
              />
            </div>

            <button type="submit">
              <span>sign up</span>
            </button>
          </form>
          <p>Already Have One ?</p>
          <button className="signup-btn">
            <Link to="/Singin">sign in</Link>
          </button>
        </div>
      </div>
      <Footer />
      <ToastContainer />
    </>
  );
};

export default SignUp;
