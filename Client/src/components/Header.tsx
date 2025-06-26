/* eslint-disable @typescript-eslint/no-explicit-any */
export default function Header(props:any) {
    return (
      <header>
        <h1>Products [{props.products.length}]</h1>
      </header>
    );
  }