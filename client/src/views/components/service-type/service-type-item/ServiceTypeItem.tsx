import React from "react";
import classes from "./ServiceTypeItem.module.css";
import { ServiceType } from "../../../../models/serviceType";

function ServiceTypeItem({ price, timeFrame, title }: ServiceType) {
  return (
    <li>
      <h5>{title}</h5>
      <section className={classes.attributes}>
        <span>Price: {price}</span>
        <span>Time Frame: {timeFrame}</span>
      </section>
    </li>
  );
}

export default ServiceTypeItem;
