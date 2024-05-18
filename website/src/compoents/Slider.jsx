import { Splide, SplideSlide } from "@splidejs/react-splide";
import "@splidejs/react-splide/css";
const Slider = () => {
  return (
    <div className="container">
      <Splide
        aria-label="My Favorite Images"
        options={{
          rewind: true,
          type: "loop",
          autoplay: true,
          pauseOnHover: true,
        }}
      >
        <SplideSlide>
          <img
            src="https://img.freepik.com/free-photo/shopping-cart-full-products-inside-supermarket_123827-28165.jpg?t=st=1714067916~exp=1714071516~hmac=7be1204608c6e0001cecfa4d4088600482be4b96ab41871baa6d4ce2178c7558&w=1380"
            alt="Image 1"
          />
          <div className="slide-text">
            <h3>Explore Limitless Choices</h3>
            <p>
              Indulge in a shopping spree like never before with our extensive
              collection of products curated just for you. From fashion-forward
              apparel to innovative tech gadgets, home decor essentials to
              fitness gear, our diverse range ensures there's something for
              everyone.
            </p>
          </div>
        </SplideSlide>
        <SplideSlide>
          <img
            src="https://img.freepik.com/free-photo/lanes-shelves-with-goods-products-inside-supermarket-variety-preserves-pasta-shelves-full-tidy_123827-27553.jpg?t=st=1714067853~exp=1714071453~hmac=1d36dc8e663c64257aaa56e06f514166a98fb3870e3ec19ae01ed1823afebd1e&w=1380"
            alt="Image 1"
          />
          <div className="slide-text">
            <h3>Shop with Confidence</h3>
            <p>
              Your satisfaction is our top priority. With our commitment to
              quality, authenticity, and reliability, you can shop with complete
              peace of mind. Each product in our store undergoes rigorous
              quality checks to ensure it meets our high standards.
            </p>
          </div>
        </SplideSlide>
        <SplideSlide>
          <img
            src="https://img.freepik.com/free-photo/fresh-fruit-stalls-san-miguel-market_53876-146829.jpg?t=st=1714068074~exp=1714071674~hmac=27cd5865d21dda0e7ddb9015f0fa554d9abdefa6906d1222908da51c45fba1a4&w=1380"
            alt="Image 1"
          />
          <div className="slide-text">
            <h3>Unmatched Convenience</h3>
            <p>
              Say goodbye to the hassle of traditional shopping. With our
              user-friendly website and intuitive mobile app, you can browse,
              select, and purchase your favorite items with just a few clicks
            </p>
          </div>
        </SplideSlide>
        <SplideSlide>
          <img
            src="https://img.freepik.com/free-photo/fresh-fruit-stalls-san-miguel-market_53876-146829.jpg?t=st=1714068074~exp=1714071674~hmac=27cd5865d21dda0e7ddb9015f0fa554d9abdefa6906d1222908da51c45fba1a4&w=1380"
            alt="Image 1"
          />
          <div className="slide-text">
            <h3>Start Exploring Today</h3>
            <p>
              Ready to embark on a shopping journey like no other? Dive into our
              virtual aisles and discover a world of possibilities. At Bisku,
              the perfect shopping experience awaits.
            </p>
          </div>
        </SplideSlide>
      </Splide>
    </div>
  );
};

export default Slider;
