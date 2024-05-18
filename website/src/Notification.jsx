import Footer from "./compoents/Footer";
import NavBar from "./compoents/NavBar";

const Notification = () => {
  return (
    <>
      <NavBar />
      <div className="notifications">
        <div className="container">
          <div className="notify-head">
            <h2 className="section-head">all notifications</h2>
          </div>
          <ul className="notify-body">
            <li>we have recived your order</li>
            <li>product is available now</li>
            <li>we have recived your order</li>
            <li>product is available now</li>
          </ul>
        </div>
      </div>
      <Footer />
    </>
  );
};

export default Notification;
