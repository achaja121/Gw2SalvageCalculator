import React from 'react';

const Header = () => {
  return (
    <header style={headerStyle}>
      <div>
        <img src="your-logo.png" alt="Logo" />
      </div>
      <div>
        <a href="/about">About the Tool</a>
      </div>
    </header>
  );
};

const headerStyle = {
  backgroundColor: '#ADF8F8',
  display: 'flex',
  justifyContent: 'space-between',
  alignItems: 'center',
  padding: '15px 20px',
};

export default Header;
