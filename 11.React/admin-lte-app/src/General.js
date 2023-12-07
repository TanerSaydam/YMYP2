export default function General() {
  return (
    <>
      <div className="content-wrapper">        
        <section className="content-header">
          <div className="container-fluid">
            <div className="row mb-2">
              <div className="col-sm-6">
                <h1>Inline Charts</h1>
              </div>
              <div className="col-sm-6">
                <ol className="breadcrumb float-sm-right">
                  <li className="breadcrumb-item">
                    <a href="#">Home</a>
                  </li>
                  <li className="breadcrumb-item active">Inline Charts</li>
                </ol>
              </div>
            </div>
          </div>
        </section>
        <section className="content">
          <div className="container-fluid">
            <div className="card card-default color-palette-box">
              <div className="card-header">
                <h3 className="card-title">
                  <i className="fas fa-tag" />
                  Color Palette
                </h3>
              </div>
              <div className="card-body">
                <div className="col-12">
                  <h5>Theme Colors</h5>
                </div>
                {/* /.col-12 */}
                <div className="row">
                  <div className="col-sm-4 col-md-2">
                    <h4 className="text-center">Primary</h4>
                    <div className="color-palette-set">
                      <div className="bg-primary color-palette">
                        <span>#007bff</span>
                      </div>
                      <div className="bg-primary disabled color-palette">
                        <span>Disabled</span>
                      </div>
                    </div>
                  </div>
                  {/* /.col */}
                  <div className="col-sm-4 col-md-2">
                    <h4 className="text-center">Secondary</h4>
                    <div className="color-palette-set">
                      <div className="bg-secondary color-palette">
                        <span>#6c757d</span>
                      </div>
                      <div className="bg-secondary disabled color-palette">
                        <span>Disabled</span>
                      </div>
                    </div>
                  </div>
                  {/* /.col */}
                  <div className="col-sm-4 col-md-2">
                    <h4 className="text-center">Info</h4>
                    <div className="color-palette-set">
                      <div className="bg-info color-palette">
                        <span>#17a2b8</span>
                      </div>
                      <div className="bg-info disabled color-palette">
                        <span>Disabled</span>
                      </div>
                    </div>
                  </div>
                  {/* /.col */}
                  <div className="col-sm-4 col-md-2">
                    <h4 className="text-center">Success</h4>
                    <div className="color-palette-set">
                      <div className="bg-success color-palette">
                        <span>#28a745</span>
                      </div>
                      <div className="bg-success disabled color-palette">
                        <span>Disabled</span>
                      </div>
                    </div>
                  </div>
                  {/* /.col */}
                  <div className="col-sm-4 col-md-2">
                    <h4 className="text-center bg-warning">Warning</h4>
                    <div className="color-palette-set">
                      <div className="bg-warning color-palette">
                        <span>#ffc107</span>
                      </div>
                      <div className="bg-warning disabled color-palette">
                        <span>Disabled</span>
                      </div>
                    </div>
                  </div>
                  {/* /.col */}
                  <div className="col-sm-4 col-md-2">
                    <h4 className="text-center">Danger</h4>
                    <div className="color-palette-set">
                      <div className="bg-danger color-palette">
                        <span>#dc3545</span>
                      </div>
                      <div className="bg-danger disabled color-palette">
                        <span>Disabled</span>
                      </div>
                    </div>
                  </div>
                  {/* /.col */}
                </div>
                {/* /.row */}
                <div className="col-12">
                  <h5 className="mt-3">Black/White Nuances</h5>
                </div>
                {/* /.col-12 */}
                <div className="row">
                  <div className="col-sm-4 col-md-2">
                    <h4 className="text-center">Black</h4>
                    <div className="color-palette-set">
                      <div className="bg-black color-palette">
                        <span>#000000</span>
                      </div>
                      <div className="bg-black disabled color-palette">
                        <span>Disabled</span>
                      </div>
                    </div>
                  </div>
                  {/* /.col */}
                  <div className="col-sm-4 col-md-2">
                    <h4 className="text-center">Gray Dark</h4>
                    <div className="color-palette-set">
                      <div className="bg-gray-dark color-palette">
                        <span>#343a40</span>
                      </div>
                      <div className="bg-gray-dark disabled color-palette">
                        <span>Disabled</span>
                      </div>
                    </div>
                  </div>
                  {/* /.col */}
                  <div className="col-sm-4 col-md-2">
                    <h4 className="text-center">Gray</h4>
                    <div className="color-palette-set">
                      <div className="bg-gray color-palette">
                        <span>#adb5bd</span>
                      </div>
                      <div className="bg-gray disabled color-palette">
                        <span>Disabled</span>
                      </div>
                    </div>
                  </div>
                  {/* /.col */}
                  <div className="col-sm-4 col-md-2">
                    <h4 className="text-center bg-light">Light</h4>
                    <div className="color-palette-set">
                      <div className="bg-light color-palette">
                        <span>#1f2d3d</span>
                      </div>
                      <div className="bg-light disabled color-palette">
                        <span>Disabled</span>
                      </div>
                    </div>
                  </div>
                  {/* /.col */}
                </div>
                {/* /.row */}
                <div className="col-12">
                  <h5 className="mt-3">Colors</h5>
                </div>
                {/* /.col-12 */}
                <div className="row">
                  <div className="col-sm-4 col-md-2">
                    <h4 className="text-center bg-indigo">Indigo</h4>
                    <div className="color-palette-set">
                      <div className="bg-indigo color-palette">
                        <span>#6610f2</span>
                      </div>
                      <div className="bg-indigo disabled color-palette">
                        <span>Disabled</span>
                      </div>
                    </div>
                  </div>
                  {/* /.col */}
                  <div className="col-sm-4 col-md-2">
                    <h4 className="text-center bg-lightblue">Lightblue</h4>
                    <div className="color-palette-set">
                      <div className="bg-lightblue color-palette">
                        <span>#3c8dbc</span>
                      </div>
                      <div className="bg-lightblue disabled color-palette">
                        <span>Disabled</span>
                      </div>
                    </div>
                  </div>
                  {/* /.col */}
                  <div className="col-sm-4 col-md-2">
                    <h4 className="text-center bg-navy">Navy</h4>
                    <div className="color-palette-set">
                      <div className="bg-navy color-palette">
                        <span>#001f3f</span>
                      </div>
                      <div className="bg-navy disabled color-palette">
                        <span>Disabled</span>
                      </div>
                    </div>
                  </div>
                  {/* /.col */}
                  <div className="col-sm-4 col-md-2">
                    <h4 className="text-center bg-purple">Purple</h4>
                    <div className="color-palette-set">
                      <div className="bg-purple color-palette">
                        <span>#605ca8</span>
                      </div>
                      <div className="bg-purple disabled color-palette">
                        <span>Disabled</span>
                      </div>
                    </div>
                  </div>
                  {/* /.col */}
                  <div className="col-sm-4 col-md-2">
                    <h4 className="text-center bg-fuchsia">Fuchsia</h4>
                    <div className="color-palette-set">
                      <div className="bg-fuchsia color-palette">
                        <span>#f012be</span>
                      </div>
                      <div className="bg-fuchsia disabled color-palette">
                        <span>Disabled</span>
                      </div>
                    </div>
                  </div>
                  {/* /.col */}
                  <div className="col-sm-4 col-md-2">
                    <h4 className="text-center bg-pink">Pink</h4>
                    <div className="color-palette-set">
                      <div className="bg-pink color-palette">
                        <span>#e83e8c</span>
                      </div>
                      <div className="bg-pink disabled color-palette">
                        <span>Disabled</span>
                      </div>
                    </div>
                  </div>
                  {/* /.col */}
                  <div className="col-sm-4 col-md-2">
                    <h4 className="text-center bg-maroon">Maroon</h4>
                    <div className="color-palette-set">
                      <div className="bg-maroon color-palette">
                        <span>#d81b60</span>
                      </div>
                      <div className="bg-maroon disabled color-palette">
                        <span>Disabled</span>
                      </div>
                    </div>
                  </div>
                  {/* /.col */}
                  <div className="col-sm-4 col-md-2">
                    <h4 className="text-center bg-orange">Orange</h4>
                    <div className="color-palette-set">
                      <div className="bg-orange color-palette">
                        <span>#ff851b</span>
                      </div>
                      <div className="bg-orange disabled color-palette">
                        <span>Disabled</span>
                      </div>
                    </div>
                  </div>
                  {/* /.col */}
                  <div className="col-sm-4 col-md-2">
                    <h4 className="text-center bg-lime">Lime</h4>
                    <div className="color-palette-set">
                      <div className="bg-lime color-palette">
                        <span>#01ff70</span>
                      </div>
                      <div className="bg-lime disabled color-palette">
                        <span>Disabled</span>
                      </div>
                    </div>
                  </div>
                  {/* /.col */}
                  <div className="col-sm-4 col-md-2">
                    <h4 className="text-center bg-teal">Teal</h4>
                    <div className="color-palette-set">
                      <div className="bg-teal color-palette">
                        <span>#39cccc</span>
                      </div>
                      <div className="bg-teal disabled color-palette">
                        <span>Disabled</span>
                      </div>
                    </div>
                  </div>
                  {/* /.col */}
                  <div className="col-sm-4 col-md-2">
                    <h4 className="text-center bg-olive">Olive</h4>
                    <div className="color-palette-set">
                      <div className="bg-olive color-palette">
                        <span>#3d9970</span>
                      </div>
                      <div className="bg-olive disabled color-palette">
                        <span>Disabled</span>
                      </div>
                    </div>
                  </div>
                  {/* /.col */}
                </div>
                {/* /.row */}
              </div>
              {/* /.card-body */}
            </div>
            {/* /.card */}
            {/* START ALERTS AND CALLOUTS */}
            <h5 className="mt-4 mb-2">Alerts and Callouts</h5>
            <div className="row">
              <div className="col-md-6">
                <div className="card card-default">
                  <div className="card-header">
                    <h3 className="card-title">
                      <i className="fas fa-exclamation-triangle" />
                      Alerts
                    </h3>
                  </div>
                  {/* /.card-header */}
                  <div className="card-body">
                    <div className="alert alert-danger alert-dismissible">
                      <button
                        type="button"
                        className="close"
                        data-dismiss="alert"
                        aria-hidden="true"
                      >
                        ×
                      </button>
                      <h5>
                        <i className="icon fas fa-ban" /> Alert!
                      </h5>
                      Danger alert preview. This alert is dismissable. A wonderful
                      serenity has taken possession of my entire soul, like these
                      sweet mornings of spring which I enjoy with my whole heart.
                    </div>
                    <div className="alert alert-info alert-dismissible">
                      <button
                        type="button"
                        className="close"
                        data-dismiss="alert"
                        aria-hidden="true"
                      >
                        ×
                      </button>
                      <h5>
                        <i className="icon fas fa-info" /> Alert!
                      </h5>
                      Info alert preview. This alert is dismissable.
                    </div>
                    <div className="alert alert-warning alert-dismissible">
                      <button
                        type="button"
                        className="close"
                        data-dismiss="alert"
                        aria-hidden="true"
                      >
                        ×
                      </button>
                      <h5>
                        <i className="icon fas fa-exclamation-triangle" /> Alert!
                      </h5>
                      Warning alert preview. This alert is dismissable.
                    </div>
                    <div className="alert alert-success alert-dismissible">
                      <button
                        type="button"
                        className="close"
                        data-dismiss="alert"
                        aria-hidden="true"
                      >
                        ×
                      </button>
                      <h5>
                        <i className="icon fas fa-check" /> Alert!
                      </h5>
                      Success alert preview. This alert is dismissable.
                    </div>
                  </div>
                  {/* /.card-body */}
                </div>
                {/* /.card */}
              </div>
              {/* /.col */}
              <div className="col-md-6">
                <div className="card card-default">
                  <div className="card-header">
                    <h3 className="card-title">
                      <i className="fas fa-bullhorn" />
                      Callouts
                    </h3>
                  </div>
                  {/* /.card-header */}
                  <div className="card-body">
                    <div className="callout callout-danger">
                      <h5>I am a danger callout!</h5>
                      <p>
                        There is a problem that we need to fix. A wonderful serenity
                        has taken possession of my entire soul, like these sweet
                        mornings of spring which I enjoy with my whole heart.
                      </p>
                    </div>
                    <div className="callout callout-info">
                      <h5>I am an info callout!</h5>
                      <p>Follow the steps to continue to payment.</p>
                    </div>
                    <div className="callout callout-warning">
                      <h5>I am a warning callout!</h5>
                      <p>This is a yellow callout.</p>
                    </div>
                    <div className="callout callout-success">
                      <h5>I am a success callout!</h5>
                      <p>This is a green callout.</p>
                    </div>
                  </div>
                  {/* /.card-body */}
                </div>
                {/* /.card */}
              </div>
              {/* /.col */}
            </div>
            {/* /.row */}
            {/* END ALERTS AND CALLOUTS */}
            <h5 className="mt-4 mb-2">Tabs in Cards</h5>
            <div className="row">
              <div className="col-12">
                {/* Custom Tabs */}
                <div className="card">
                  <div className="card-header d-flex p-0">
                    <h3 className="card-title p-3">Tabs</h3>
                    <ul className="nav nav-pills ml-auto p-2">
                      <li className="nav-item">
                        <a
                          className="nav-link active"
                          href="#tab_1"
                          data-toggle="tab"
                        >
                          Tab 1
                        </a>
                      </li>
                      <li className="nav-item">
                        <a className="nav-link" href="#tab_2" data-toggle="tab">
                          Tab 2
                        </a>
                      </li>
                      <li className="nav-item">
                        <a className="nav-link" href="#tab_3" data-toggle="tab">
                          Tab 3
                        </a>
                      </li>
                      <li className="nav-item dropdown">
                        <a
                          className="nav-link dropdown-toggle"
                          data-toggle="dropdown"
                          href="#"
                        >
                          Dropdown <span className="caret" />
                        </a>
                        <div className="dropdown-menu">
                          <a className="dropdown-item" tabIndex={-1} href="#">
                            Action
                          </a>
                          <a className="dropdown-item" tabIndex={-1} href="#">
                            Another action
                          </a>
                          <a className="dropdown-item" tabIndex={-1} href="#">
                            Something else here
                          </a>
                          <div className="dropdown-divider" />
                          <a className="dropdown-item" tabIndex={-1} href="#">
                            Separated link
                          </a>
                        </div>
                      </li>
                    </ul>
                  </div>
                  {/* /.card-header */}
                  <div className="card-body">
                    <div className="tab-content">
                      <div className="tab-pane active" id="tab_1">
                        A wonderful serenity has taken possession of my entire soul,
                        like these sweet mornings of spring which I enjoy with my
                        whole heart. I am alone, and feel the charm of existence in
                        this spot, which was created for the bliss of souls like
                        mine. I am so happy, my dear friend, so absorbed in the
                        exquisite sense of mere tranquil existence, that I neglect
                        my talents. I should be incapable of drawing a single stroke
                        at the present moment; and yet I feel that I never was a
                        greater artist than now.
                      </div>
                      {/* /.tab-pane */}
                      <div className="tab-pane" id="tab_2">
                        The European languages are members of the same family. Their
                        separate existence is a myth. For science, music, sport,
                        etc, Europe uses the same vocabulary. The languages only
                        differ in their grammar, their pronunciation and their most
                        common words. Everyone realizes why a new common language
                        would be desirable: one could refuse to pay expensive
                        translators. To achieve this, it would be necessary to have
                        uniform grammar, pronunciation and more common words. If
                        several languages coalesce, the grammar of the resulting
                        language is more simple and regular than that of the
                        individual languages.
                      </div>
                      {/* /.tab-pane */}
                      <div className="tab-pane" id="tab_3">
                        Lorem Ipsum is simply dummy text of the printing and
                        typesetting industry. Lorem Ipsum has been the industry's
                        standard dummy text ever since the 1500s, when an unknown
                        printer took a galley of type and scrambled it to make a
                        type specimen book. It has survived not only five centuries,
                        but also the leap into electronic typesetting, remaining
                        essentially unchanged. It was popularised in the 1960s with
                        the release of Letraset sheets containing Lorem Ipsum
                        passages, and more recently with desktop publishing software
                        like Aldus PageMaker including versions of Lorem Ipsum.
                      </div>
                      {/* /.tab-pane */}
                    </div>
                    {/* /.tab-content */}
                  </div>
                  {/* /.card-body */}
                </div>
                {/* ./card */}
              </div>
              {/* /.col */}
            </div>
            {/* /.row */}
            {/* END CUSTOM TABS */}
            {/* START PROGRESS BARS */}
            <h5 className="mt-4 mb-2">Progress Bars</h5>
            <div className="row">
              <div className="col-md-6">
                <div className="card">
                  <div className="card-header">
                    <h3 className="card-title">Progress Bars Different Sizes</h3>
                  </div>
                  {/* /.card-header */}
                  <div className="card-body">
                    <p>
                      <code>.progress</code>
                    </p>
                    <div className="progress">
                      <div
                        className="progress-bar bg-primary progress-bar-striped"
                        role="progressbar"
                        aria-valuenow={40}
                        aria-valuemin={0}
                        aria-valuemax={100}
                        style={{ width: "40%" }}
                      >
                        <span className="sr-only">40% Complete (success)</span>
                      </div>
                    </div>
                    <p>
                      <code>.progress-sm</code>
                    </p>
                    <div className="progress progress-sm active">
                      <div
                        className="progress-bar bg-success progress-bar-striped"
                        role="progressbar"
                        aria-valuenow={20}
                        aria-valuemin={0}
                        aria-valuemax={100}
                        style={{ width: "20%" }}
                      >
                        <span className="sr-only">20% Complete</span>
                      </div>
                    </div>
                    <p>
                      <code>.progress-xs</code>
                    </p>
                    <div className="progress progress-xs">
                      <div
                        className="progress-bar bg-warning progress-bar-striped"
                        role="progressbar"
                        aria-valuenow={60}
                        aria-valuemin={0}
                        aria-valuemax={100}
                        style={{ width: "60%" }}
                      >
                        <span className="sr-only">60% Complete (warning)</span>
                      </div>
                    </div>
                    <p>
                      <code>.progress-xxs</code>
                    </p>
                    <div className="progress progress-xxs">
                      <div
                        className="progress-bar progress-bar-danger progress-bar-striped"
                        role="progressbar"
                        aria-valuenow={60}
                        aria-valuemin={0}
                        aria-valuemax={100}
                        style={{ width: "60%" }}
                      >
                        <span className="sr-only">60% Complete (warning)</span>
                      </div>
                    </div>
                  </div>
                  {/* /.card-body */}
                </div>
                {/* /.card */}
              </div>
              {/* /.col (left) */}
              <div className="col-md-6">
                <div className="card">
                  <div className="card-header">
                    <h3 className="card-title">Progress bars</h3>
                  </div>
                  {/* /.card-header */}
                  <div className="card-body">
                    <div className="progress mb-3">
                      <div
                        className="progress-bar bg-success"
                        role="progressbar"
                        aria-valuenow={40}
                        aria-valuemin={0}
                        aria-valuemax={100}
                        style={{ width: "40%" }}
                      >
                        <span className="sr-only">40% Complete (success)</span>
                      </div>
                    </div>
                    <div className="progress mb-3">
                      <div
                        className="progress-bar bg-info"
                        role="progressbar"
                        aria-valuenow={20}
                        aria-valuemin={0}
                        aria-valuemax={100}
                        style={{ width: "20%" }}
                      >
                        <span className="sr-only">20% Complete</span>
                      </div>
                    </div>
                    <div className="progress mb-3">
                      <div
                        className="progress-bar bg-warning"
                        role="progressbar"
                        aria-valuenow={60}
                        aria-valuemin={0}
                        aria-valuemax={100}
                        style={{ width: "60%" }}
                      >
                        <span className="sr-only">60% Complete (warning)</span>
                      </div>
                    </div>
                    <div className="progress mb-3">
                      <div
                        className="progress-bar bg-danger"
                        role="progressbar"
                        aria-valuenow={80}
                        aria-valuemin={0}
                        aria-valuemax={100}
                        style={{ width: "80%" }}
                      >
                        <span className="sr-only">80% Complete</span>
                      </div>
                    </div>
                  </div>
                  {/* /.card-body */}
                </div>
                {/* /.card */}
              </div>
              {/* /.col (right) */}
            </div>
            {/* /.row */}
            <div className="row">
              <div className="col-md-6">
                <div className="card">
                  <div className="card-header">
                    <h3 className="card-title">
                      Vertical Progress Bars Different Sizes
                    </h3>
                  </div>
                  {/* /.card-header */}
                  <div className="card-body text-center">
                    <p>
                      By adding the class <code>.vertical</code> and{" "}
                      <code>.progress-sm</code>, <code>.progress-xs</code>
                      or
                      <code>.progress-xxs</code> we achieve:
                    </p>
                    <div className="progress vertical active">
                      <div
                        className="progress-bar bg-primary progress-bar-striped"
                        role="progressbar"
                        aria-valuenow={40}
                        aria-valuemin={0}
                        aria-valuemax={100}
                        style={{ height: "40%" }}
                      >
                        <span className="sr-only">40%</span>
                      </div>
                    </div>
                    <div className="progress vertical progress-sm">
                      <div
                        className="progress-bar bg-success"
                        role="progressbar"
                        aria-valuenow={20}
                        aria-valuemin={0}
                        aria-valuemax={100}
                        style={{ height: "100%" }}
                      >
                        <span className="sr-only">100%</span>
                      </div>
                    </div>
                    <div className="progress vertical progress-xs">
                      <div
                        className="progress-bar bg-warning progress-bar-striped"
                        role="progressbar"
                        aria-valuenow={60}
                        aria-valuemin={0}
                        aria-valuemax={100}
                        style={{ height: "60%" }}
                      >
                        <span className="sr-only">60%</span>
                      </div>
                    </div>
                    <div className="progress vertical progress-xxs">
                      <div
                        className="progress-bar bg-info progress-bar-striped"
                        role="progressbar"
                        aria-valuenow={60}
                        aria-valuemin={0}
                        aria-valuemax={100}
                        style={{ height: "60%" }}
                      >
                        <span className="sr-only">60%</span>
                      </div>
                    </div>
                  </div>
                  {/* /.card-body */}
                </div>
                {/* /.card */}
              </div>
              {/* /.col (left) */}
              <div className="col-md-6">
                <div className="card">
                  <div className="card-header">
                    <h3 className="card-title">Vertical Progress bars</h3>
                  </div>
                  {/* /.card-header */}
                  <div className="card-body text-center">
                    <p>
                      By adding the class <code>.vertical</code> we achieve:
                    </p>
                    <div className="progress vertical">
                      <div
                        className="progress-bar bg-success"
                        role="progressbar"
                        aria-valuenow={40}
                        aria-valuemin={0}
                        aria-valuemax={100}
                        style={{ height: "40%" }}
                      >
                        <span className="sr-only">40%</span>
                      </div>
                    </div>
                    <div className="progress vertical">
                      <div
                        className="progress-bar bg-info"
                        role="progressbar"
                        aria-valuenow={20}
                        aria-valuemin={0}
                        aria-valuemax={100}
                        style={{ height: "20%" }}
                      >
                        <span className="sr-only">20%</span>
                      </div>
                    </div>
                    <div className="progress vertical">
                      <div
                        className="progress-bar bg-warning"
                        role="progressbar"
                        aria-valuenow={60}
                        aria-valuemin={0}
                        aria-valuemax={100}
                        style={{ height: "60%" }}
                      >
                        <span className="sr-only">60%</span>
                      </div>
                    </div>
                    <div className="progress vertical">
                      <div
                        className="progress-bar bg-danger"
                        role="progressbar"
                        aria-valuenow={80}
                        aria-valuemin={0}
                        aria-valuemax={100}
                        style={{ height: "80%" }}
                      >
                        <span className="sr-only">80%</span>
                      </div>
                    </div>
                  </div>
                  {/* /.card-body */}
                </div>
                {/* /.card */}
              </div>
              {/* /.col (right) */}
            </div>
            {/* /.row */}
            {/* END PROGRESS BARS */}
            {/* START ACCORDION & CAROUSEL*/}
            <h5 className="mt-4 mb-2">Bootstrap Accordion &amp; Carousel</h5>
            <div className="row">
              <div className="col-md-6">
                <div className="card">
                  <div className="card-header">
                    <h3 className="card-title">Collapsible Accordion</h3>
                  </div>
                  {/* /.card-header */}
                  <div className="card-body">
                    {/* we are adding the accordion ID so Bootstrap's collapse plugin detects it */}
                    <div id="accordion">
                      <div className="card card-primary">
                        <div className="card-header">
                          <h4 className="card-title w-100">
                            <a
                              className="d-block w-100"
                              data-toggle="collapse"
                              href="#collapseOne"
                            >
                              Collapsible Group Item #1
                            </a>
                          </h4>
                        </div>
                        <div
                          id="collapseOne"
                          className="collapse show"
                          data-parent="#accordion"
                        >
                          <div className="card-body">
                            Anim pariatur cliche reprehenderit, enim eiusmod high
                            life accusamus terry richardson ad squid. 3 wolf moon
                            officia aute, non cupidatat skateboard dolor brunch.
                            Food truck quinoa nesciunt laborum eiusmod. Brunch 3
                            wolf moon tempor, sunt aliqua put a bird on it squid
                            single-origin coffee nulla assumenda shoreditch et.
                            Nihil anim keffiyeh helvetica, craft beer labore wes
                            anderson cred nesciunt sapiente ea proident. Ad vegan
                            excepteur butcher vice lomo. Leggings occaecat craft
                            beer farm-to-table, raw denim aesthetic synth nesciunt
                            you probably haven't heard of them accusamus labore
                            sustainable VHS.
                          </div>
                        </div>
                      </div>
                      <div className="card card-danger">
                        <div className="card-header">
                          <h4 className="card-title w-100">
                            <a
                              className="d-block w-100"
                              data-toggle="collapse"
                              href="#collapseTwo"
                            >
                              Collapsible Group Danger
                            </a>
                          </h4>
                        </div>
                        <div
                          id="collapseTwo"
                          className="collapse"
                          data-parent="#accordion"
                        >
                          <div className="card-body">
                            Anim pariatur cliche reprehenderit, enim eiusmod high
                            life accusamus terry richardson ad squid. 3 wolf moon
                            officia aute, non cupidatat skateboard dolor brunch.
                            Food truck quinoa nesciunt laborum eiusmod. Brunch 3
                            wolf moon tempor, sunt aliqua put a bird on it squid
                            single-origin coffee nulla assumenda shoreditch et.
                            Nihil anim keffiyeh helvetica, craft beer labore wes
                            anderson cred nesciunt sapiente ea proident. Ad vegan
                            excepteur butcher vice lomo. Leggings occaecat craft
                            beer farm-to-table, raw denim aesthetic synth nesciunt
                            you probably haven't heard of them accusamus labore
                            sustainable VHS.
                          </div>
                        </div>
                      </div>
                      <div className="card card-success">
                        <div className="card-header">
                          <h4 className="card-title w-100">
                            <a
                              className="d-block w-100"
                              data-toggle="collapse"
                              href="#collapseThree"
                            >
                              Collapsible Group Success
                            </a>
                          </h4>
                        </div>
                        <div
                          id="collapseThree"
                          className="collapse"
                          data-parent="#accordion"
                        >
                          <div className="card-body">
                            Anim pariatur cliche reprehenderit, enim eiusmod high
                            life accusamus terry richardson ad squid. 3 wolf moon
                            officia aute, non cupidatat skateboard dolor brunch.
                            Food truck quinoa nesciunt laborum eiusmod. Brunch 3
                            wolf moon tempor, sunt aliqua put a bird on it squid
                            single-origin coffee nulla assumenda shoreditch et.
                            Nihil anim keffiyeh helvetica, craft beer labore wes
                            anderson cred nesciunt sapiente ea proident. Ad vegan
                            excepteur butcher vice lomo. Leggings occaecat craft
                            beer farm-to-table, raw denim aesthetic synth nesciunt
                            you probably haven't heard of them accusamus labore
                            sustainable VHS.
                          </div>
                        </div>
                      </div>
                    </div>
                  </div>
                  {/* /.card-body */}
                </div>
                {/* /.card */}
              </div>
              {/* /.col */}
              <div className="col-md-6">
                <div className="card">
                  <div className="card-header">
                    <h3 className="card-title">Carousel</h3>
                  </div>
                  {/* /.card-header */}
                  <div className="card-body">
                    <div
                      id="carouselExampleIndicators"
                      className="carousel slide"
                      data-ride="carousel"
                    >
                      <ol className="carousel-indicators">
                        <li
                          data-target="#carouselExampleIndicators"
                          data-slide-to={0}
                          className="active"
                        />
                        <li
                          data-target="#carouselExampleIndicators"
                          data-slide-to={1}
                        />
                        <li
                          data-target="#carouselExampleIndicators"
                          data-slide-to={2}
                        />
                      </ol>
                      <div className="carousel-inner">
                        <div className="carousel-item active">
                          <img
                            className="d-block w-100"
                            src="https://placehold.it/900x500/39CCCC/ffffff&text=I+Love+Bootstrap"
                            alt="First slide"
                          />
                        </div>
                        <div className="carousel-item">
                          <img
                            className="d-block w-100"
                            src="https://placehold.it/900x500/3c8dbc/ffffff&text=I+Love+Bootstrap"
                            alt="Second slide"
                          />
                        </div>
                        <div className="carousel-item">
                          <img
                            className="d-block w-100"
                            src="https://placehold.it/900x500/f39c12/ffffff&text=I+Love+Bootstrap"
                            alt="Third slide"
                          />
                        </div>
                      </div>
                      <a
                        className="carousel-control-prev"
                        href="#carouselExampleIndicators"
                        role="button"
                        data-slide="prev"
                      >
                        <span
                          className="carousel-control-custom-icon"
                          aria-hidden="true"
                        >
                          <i className="fas fa-chevron-left" />
                        </span>
                        <span className="sr-only">Previous</span>
                      </a>
                      <a
                        className="carousel-control-next"
                        href="#carouselExampleIndicators"
                        role="button"
                        data-slide="next"
                      >
                        <span
                          className="carousel-control-custom-icon"
                          aria-hidden="true"
                        >
                          <i className="fas fa-chevron-right" />
                        </span>
                        <span className="sr-only">Next</span>
                      </a>
                    </div>
                  </div>
                  {/* /.card-body */}
                </div>
                {/* /.card */}
              </div>
              {/* /.col */}
            </div>
            {/* /.row */}
            {/* END ACCORDION & CAROUSEL*/}
            {/* START TYPOGRAPHY */}
            <h5 className="mt-4 mb-2">Typography</h5>
            <div className="row">
              <div className="col-md-6">
                <div className="card">
                  <div className="card-header">
                    <h3 className="card-title">
                      <i className="fas fa-text-width" />
                      Headlines
                    </h3>
                  </div>
                  {/* /.card-header */}
                  <div className="card-body">
                    <h1>h1. Bootstrap heading</h1>
                    <h2>h2. Bootstrap heading</h2>
                    <h3>h3. Bootstrap heading</h3>
                    <h4>h4. Bootstrap heading</h4>
                    <h5>h5. Bootstrap heading</h5>
                    <h6>h6. Bootstrap heading</h6>
                  </div>
                  {/* /.card-body */}
                </div>
                {/* /.card */}
              </div>
              {/* ./col */}
              <div className="col-md-6">
                <div className="card">
                  <div className="card-header">
                    <h3 className="card-title">
                      <i className="fas fa-text-width" />
                      Text Emphasis
                    </h3>
                  </div>
                  {/* /.card-header */}
                  <div className="card-body">
                    <p className="lead">Lead to emphasize importance</p>
                    <p className="text-success">Text green to emphasize success</p>
                    <p className="text-info">Text aqua to emphasize info</p>
                    <p className="text-primary">
                      Text light blue to emphasize info (2)
                    </p>
                    <p className="text-danger">Text red to emphasize danger</p>
                    <p className="text-warning">Text yellow to emphasize warning</p>
                    <p className="text-muted">Text muted to emphasize general</p>
                  </div>
                  {/* /.card-body */}
                </div>
                {/* /.card */}
              </div>
              {/* ./col */}
            </div>
            {/* /.row */}
            <div className="row">
              <div className="col-md-6">
                <div className="card">
                  <div className="card-header">
                    <h3 className="card-title">
                      <i className="fas fa-text-width" />
                      Primary Block Quotes
                    </h3>
                  </div>
                  {/* /.card-header */}
                  <div className="card-body">
                    <blockquote>
                      <p>
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit.
                        Integer posuere erat a ante.
                      </p>
                      <small>
                        Someone famous in{" "}
                        <cite title="Source Title">Source Title</cite>
                      </small>
                    </blockquote>
                  </div>
                  {/* /.card-body */}
                </div>
                {/* /.card */}
              </div>
              {/* ./col */}
              <div className="col-md-6">
                <div className="card">
                  <div className="card-header">
                    <h3 className="card-title">
                      <i className="fas fa-text-width" />
                      Secondary Block Quotes
                    </h3>
                  </div>
                  {/* /.card-header */}
                  <div className="card-body clearfix">
                    <blockquote className="quote-secondary">
                      <p>
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit.
                        Integer posuere erat a ante.
                      </p>
                      <small>
                        Someone famous in{" "}
                        <cite title="Source Title">Source Title</cite>
                      </small>
                    </blockquote>
                  </div>
                  {/* /.card-body */}
                </div>
                {/* /.card */}
              </div>
              {/* ./col */}
            </div>
            {/* /.row */}
            <div className="row">
              <div className="col-md-4">
                <div className="card">
                  <div className="card-header">
                    <h3 className="card-title">
                      <i className="fas fa-text-width" />
                      Unordered List
                    </h3>
                  </div>
                  {/* /.card-header */}
                  <div className="card-body">
                    <ul>
                      <li>Lorem ipsum dolor sit amet</li>
                      <li>Consectetur adipiscing elit</li>
                      <li>Integer molestie lorem at massa</li>
                      <li>Facilisis in pretium nisl aliquet</li>
                      <li>
                        Nulla volutpat aliquam velit
                        <ul>
                          <li>Phasellus iaculis neque</li>
                          <li>Purus sodales ultricies</li>
                          <li>Vestibulum laoreet porttitor sem</li>
                          <li>Ac tristique libero volutpat at</li>
                        </ul>
                      </li>
                      <li>Faucibus porta lacus fringilla vel</li>
                      <li>Aenean sit amet erat nunc</li>
                      <li>Eget porttitor lorem</li>
                    </ul>
                  </div>
                  {/* /.card-body */}
                </div>
                {/* /.card */}
              </div>
              {/* ./col */}
              <div className="col-md-4">
                <div className="card">
                  <div className="card-header">
                    <h3 className="card-title">
                      <i className="fas fa-text-width" />
                      Ordered Lists
                    </h3>
                  </div>
                  {/* /.card-header */}
                  <div className="card-body">
                    <ol>
                      <li>Lorem ipsum dolor sit amet</li>
                      <li>Consectetur adipiscing elit</li>
                      <li>Integer molestie lorem at massa</li>
                      <li>Facilisis in pretium nisl aliquet</li>
                      <li>
                        Nulla volutpat aliquam velit
                        <ol>
                          <li>Phasellus iaculis neque</li>
                          <li>Purus sodales ultricies</li>
                          <li>Vestibulum laoreet porttitor sem</li>
                          <li>Ac tristique libero volutpat at</li>
                        </ol>
                      </li>
                      <li>Faucibus porta lacus fringilla vel</li>
                      <li>Aenean sit amet erat nunc</li>
                      <li>Eget porttitor lorem</li>
                    </ol>
                  </div>
                  {/* /.card-body */}
                </div>
                {/* /.card */}
              </div>
              {/* ./col */}
              <div className="col-md-4">
                <div className="card">
                  <div className="card-header">
                    <h3 className="card-title">
                      <i className="fas fa-text-width" />
                      Unstyled List
                    </h3>
                  </div>
                  {/* /.card-header */}
                  <div className="card-body">
                    <ul className="list-unstyled">
                      <li>Lorem ipsum dolor sit amet</li>
                      <li>Consectetur adipiscing elit</li>
                      <li>Integer molestie lorem at massa</li>
                      <li>Facilisis in pretium nisl aliquet</li>
                      <li>
                        Nulla volutpat aliquam velit
                        <ul>
                          <li>Phasellus iaculis neque</li>
                          <li>Purus sodales ultricies</li>
                          <li>Vestibulum laoreet porttitor sem</li>
                          <li>Ac tristique libero volutpat at</li>
                        </ul>
                      </li>
                      <li>Faucibus porta lacus fringilla vel</li>
                      <li>Aenean sit amet erat nunc</li>
                      <li>Eget porttitor lorem</li>
                    </ul>
                  </div>
                  {/* /.card-body */}
                </div>
                {/* /.card */}
              </div>
              {/* ./col */}
            </div>
            {/* /.row */}
            <div className="row">
              <div className="col-md-6">
                <div className="card">
                  <div className="card-header">
                    <h3 className="card-title">
                      <i className="fas fa-text-width" />
                      Description
                    </h3>
                  </div>
                  {/* /.card-header */}
                  <div className="card-body">
                    <dl>
                      <dt>Description lists</dt>
                      <dd>A description list is perfect for defining terms.</dd>
                      <dt>Euismod</dt>
                      <dd>
                        Vestibulum id ligula porta felis euismod semper eget lacinia
                        odio sem nec elit.
                      </dd>
                      <dd>Donec id elit non mi porta gravida at eget metus.</dd>
                      <dt>Malesuada porta</dt>
                      <dd>Etiam porta sem malesuada magna mollis euismod.</dd>
                    </dl>
                  </div>
                  {/* /.card-body */}
                </div>
                {/* /.card */}
              </div>
              {/* ./col */}
              <div className="col-md-6">
                <div className="card">
                  <div className="card-header">
                    <h3 className="card-title">
                      <i className="fas fa-text-width" />
                      Description Horizontal
                    </h3>
                  </div>
                  {/* /.card-header */}
                  <div className="card-body">
                    <dl className="row">
                      <dt className="col-sm-4">Description lists</dt>
                      <dd className="col-sm-8">
                        A description list is perfect for defining terms.
                      </dd>
                      <dt className="col-sm-4">Euismod</dt>
                      <dd className="col-sm-8">
                        Vestibulum id ligula porta felis euismod semper eget lacinia
                        odio sem nec elit.
                      </dd>
                      <dd className="col-sm-8 offset-sm-4">
                        Donec id elit non mi porta gravida at eget metus.
                      </dd>
                      <dt className="col-sm-4">Malesuada porta</dt>
                      <dd className="col-sm-8">
                        Etiam porta sem malesuada magna mollis euismod.
                      </dd>
                      <dt className="col-sm-4">
                        Felis euismod semper eget lacinia
                      </dt>
                      <dd className="col-sm-8">
                        Fusce dapibus, tellus ac cursus commodo, tortor mauris
                        condimentum nibh, ut fermentum massa justo sit amet risus.
                      </dd>
                    </dl>
                  </div>
                  {/* /.card-body */}
                </div>
                {/* /.card */}
              </div>
              {/* ./col */}
            </div>
            {/* /.row */}
            <div className="row">
              <div className="col-12">
                <div className="card">
                  <div className="card-header">
                    <h3 className="card-title">Pagination Month</h3>
                  </div>
                  <div className="card-body">
                    <ul className="pagination pagination-month justify-content-center">
                      <li className="page-item">
                        <a className="page-link" href="#">
                          «
                        </a>
                      </li>
                      <li className="page-item">
                        <a className="page-link" href="#">
                          <p className="page-month">Jan</p>
                          <p className="page-year">2021</p>
                        </a>
                      </li>
                      <li className="page-item active">
                        <a className="page-link" href="#">
                          <p className="page-month">Feb</p>
                          <p className="page-year">2021</p>
                        </a>
                      </li>
                      <li className="page-item">
                        <a className="page-link" href="#">
                          <p className="page-month">Mar</p>
                          <p className="page-year">2021</p>
                        </a>
                      </li>
                      <li className="page-item">
                        <a className="page-link" href="#">
                          <p className="page-month">Apr</p>
                          <p className="page-year">2021</p>
                        </a>
                      </li>
                      <li className="page-item">
                        <a className="page-link" href="#">
                          <p className="page-month">May</p>
                          <p className="page-year">2021</p>
                        </a>
                      </li>
                      <li className="page-item">
                        <a className="page-link" href="#">
                          <p className="page-month">Jun</p>
                          <p className="page-year">2021</p>
                        </a>
                      </li>
                      <li className="page-item">
                        <a className="page-link" href="#">
                          <p className="page-month">Jul</p>
                          <p className="page-year">2021</p>
                        </a>
                      </li>
                      <li className="page-item">
                        <a className="page-link" href="#">
                          <p className="page-month">Aug</p>
                          <p className="page-year">2021</p>
                        </a>
                      </li>
                      <li className="page-item">
                        <a className="page-link" href="#">
                          <p className="page-month">Sep</p>
                          <p className="page-year">2021</p>
                        </a>
                      </li>
                      <li className="page-item">
                        <a className="page-link" href="#">
                          <p className="page-month">Oct</p>
                          <p className="page-year">2021</p>
                        </a>
                      </li>
                      <li className="page-item">
                        <a className="page-link" href="#">
                          <p className="page-month">Nov</p>
                          <p className="page-year">2021</p>
                        </a>
                      </li>
                      <li className="page-item">
                        <a className="page-link" href="#">
                          <p className="page-month">Dec</p>
                          <p className="page-year">2021</p>
                        </a>
                      </li>
                      <li className="page-item">
                        <a className="page-link" href="#">
                          »
                        </a>
                      </li>
                    </ul>
                  </div>
                </div>
              </div>
            </div>
            {/* /.row */}
            {/* END TYPOGRAPHY */}
          </div>
          {/* /.container-fluid */}
        </section>
        {/* /.content */}
      </div>
    </>
  )
}