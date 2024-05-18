import icon from "./assets/icons/set.png";
import icon1 from "./assets/icons/bread-icon.png";
import icon2 from "./assets/icons/chicken.png";
import icon3 from "./assets/icons/grainfood-icon.png";
import icon4 from "./assets/icons/dairy.png";
import icon5 from "./assets/icons/fruit-icon.png";
import icon6 from "./assets/icons/seafood-icon.png";
import icon7 from "./assets/icons/softdrinks.png";
import icon8 from "./assets/icons/cleaner.png";
import icon9 from "./assets/icons/vegetables.png";
// import icon6 from "./assets/icons/softdrinks.png";
import CategoryItem from "./compoents/CategoryItem";
import { Link } from "react-router-dom";

const Category = () => {
  return (
    <div className="category">
      <div className="container">
        <div className="category-header">
          <h2 className="section-head">our categories</h2>
          <Link to="/Categories">all the categories</Link>
        </div>
        <div className="category-content">
          <CategoryItem
            title="all the categories"
            name="all categories"
            icon={icon}
          />
          <CategoryItem title="bread" name="bread" icon={icon1} />
          <CategoryItem
            title="chicken and meat section"
            name="poultry"
            icon={icon2}
          />
          <CategoryItem
            title="beans , pasta, breakfast , cereals , rice"
            name="grainfood"
            icon={icon3}
          />
          <CategoryItem
            title="milk, cheese, yogurt"
            name="dairy"
            icon={icon4}
          />
          <CategoryItem title="Fresh Tomato , Potato ,Cucumber ,Lemon , Onion .... " name="vegetables" icon={icon9} />
          <CategoryItem title="sea food" name="sea food" icon={icon6} />
          <CategoryItem title="Mangoes , Water Melon , Melon ,Banana , Grapes , ..... " name="fruit" icon={icon5} />
          <CategoryItem title="Tea , Coffee , Cold Drinks , ...." name="drinks" icon={icon7} />
          <CategoryItem title="cleaners" name="cleaners" icon={icon8} />
        </div>
      </div>
    </div>
  );
};

export default Category;

// .1.2 2- Mangoes.
// 1.1.3 3- Water Melon.
// 1.1.4 4- Melon.
// 1.1.5 5- Grapes.

