<?php

  if (FORUM_SESSIONS == 'mysql') {
      if (!$SESS_LIFE = get_cfg_var('session.gc_maxlifetime')) {
        $SESS_LIFE = 1440;
      }
    

    function _sess_open($save_path, $session_name) {
      return true;
    }

    function _sess_close() {
      return true;
    }

    function _sess_read($key) {
      $value_query = mysql_query("select value from sessions where sesskey = '" .($key) . "' and expiry > '" . time() . "'");
      $value = mysql_fetch_array($value_query);

      if (isset($value['value'])) {
        return $value['value'];
      }

      return false;
    }

    function _sess_write($key, $val) {
      global $SESS_LIFE;

      $expiry = time() + $SESS_LIFE;
      $value = $val;
	  
         
      $check_query = mysql_query("select count(*) as total from sessions where sesskey = '" .($key) . "'");
      $check = mysql_fetch_array($check_query);

      if ($check['total'] > 0) {
	  return mysql_query("update sessions set expiry = '" .($expiry) . "', value = '" .($value) . "' where sesskey = '" .($key) . "'");
      } else {
        return mysql_query("insert into sessions values ('" .($key) . "', '" .($expiry) . "', '" .($value) . "')");
      }
    }

    function _sess_destroy($key) {
      return mysql_query("delete from sessions where sesskey = '" .($key) . "'");
    }

    function _sess_gc($maxlifetime) {
      mysql_query("delete from sessions where expiry < '" . time() . "'");

      return true;
    }

    session_set_save_handler('_sess_open', '_sess_close', '_sess_read', '_sess_write', '_sess_destroy', '_sess_gc');
  }

  function tep_session_start() {
    return session_start();
  }

  function tep_session_register($variable) {
    global $$variable;
	global $session_started;
    if ($session_started == true) {
      $_SESSION[$variable] = $$variable;
      return true;
    } else {
      return false;
    }
  }
function tep_session_value($variable) {
    if(isset($_SESSION[$variable])) {
      return $_SESSION[$variable];
    } else {
      return false;
    }
  }
  function tep_session_is_registered($variable) {
    if(isset($_SESSION[$variable])) {
      return true;
    } else {
      return false;
    }
  }

  function tep_session_unregister($variable) {
    unset($_SESSION[$variable]);
  }  


  function tep_session_id($sessid = '') {
    if (!empty($sessid)) {
      return session_id($sessid);
    } else {
      return session_id();
    }
  }

  function tep_session_name($name = '') {
    if (!empty($name)) {
      return session_name($name);
    } else {
      return session_name();
    }
  }

  function tep_session_close() {
    if(is_array($_SESSION)) {
      foreach($_SESSION as $key => $value) {
        global $$key;
        $_SESSION[$key] = $$key;
      }
    }
  }  

  function tep_session_destroy() {
    return session_destroy();
  }

  function tep_session_save_path($path = '') {
    if (!empty($path)) {
      return session_save_path($path);
    } else {
      return session_save_path();
    }
  }

?>
