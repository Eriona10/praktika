import React from 'react';
import './PaymentPage.css';

const PaymentPage = () => {
  return (
    <div className="payment-page">
      <div className="payment-container">
        <h1 className="payment-title">Payment</h1>
        <form className="payment-form">
          <div className="form-group">
            <label htmlFor="cardNumber">Card Number</label>
            <input type="text" id="cardNumber" />
          </div>
          <div className="form-group">
            <label htmlFor="expiryDate">Expiry Date</label>
            <input type="text" id="expiryDate" />
          </div>
          <div className="form-group">
            <label htmlFor="cvv">CVV</label>
            <input type="text" id="cvv" />
          </div>
          <div className="form-group">
            <label htmlFor="name">Cardholder Name</label>
            <input type="text" id="name" />
          </div>
          <button className="payment-button" type="submit">Pay Now</button>
        </form>
      </div>
    </div>
  );
};

export default PaymentPage;
